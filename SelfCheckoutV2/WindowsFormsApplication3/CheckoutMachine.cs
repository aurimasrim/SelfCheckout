using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication3
{
    public enum PayingMethod { None = 0, CreditCard, Cash }
    public enum Money
    {
        M1cent = 1,
        M2cents = 2,
        M5cents = 5,
        M10cents = 10,
        M20cents = 20,
        M50cents = 50,
        M1euro = 100,
        M2euros = 200,
        M5euros = 500,
        M10euros = 1000,
        M20euros = 2000,
        M50euros = 5000,
        M100euros = 10000,
        M200euros = 20000,
        M500euros = 50000
    }
    class CheckoutMachine
    {
        public string cardPath = String.Concat(Directory.GetCurrentDirectory(), @"\creditcarddata.txt");
        public CustomArray<Product> Scannedproductsarray { get; set; }
        private Lazy<CreditCardArray> creditCardsArray;
        public DataSet CreditCardsDataSet = new DataSet();
        //private CustomArray<CreditCard> creditCardsArray;

        private int scannedProductsWeight;
        private int productsWeight;
        private PayingMethod payingMethod;
        private CreditCard payingCard = null;
        public bool scannerOn = true;
        private double priceToPay = 0;
        public bool needsApproval = false;
        public bool isAgeApproved = false;
        public double PriceToPay
        {
            get { return priceToPay; }
        }

        // grąža
        private double change = 0;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aurimas\Documents\GitHub\SelfCheckout\SelfCheckoutV2\WindowsFormsApplication3\ShopDB.mdf;Integrated Security=True";

        public double Change
        {
            get { return change; }
        }
        public CreditCard PayingCard
        {
            get { return payingCard; }
        }
        public CheckoutMachine()
        {
            Scannedproductsarray = new CustomArray<Product>();
            payingMethod = PayingMethod.None;
            //creditCardsArray = new CustomArray<CreditCard>();
            creditCardsArray = new Lazy<CreditCardArray>(() => new CreditCardArray(cardPath));

            using (var context = new ShopDBEntities1())
            {
                Product pr;
                pr = Product.Bag;
                if(context.Preke.SingleOrDefault(x => x.Barkodas == pr.Barcode) == null)
                {
                    context.Preke.Add(new Preke() { Barkodas = pr.Barcode, Kaina = pr.Price, Atributai = (int)pr.Pattributes, Kategorija = (int)pr.Pcategory, Pavadinimas = pr.Pname, Svoris = pr.Weight });
                }
                pr = Product.Tare;
                if (context.Preke.SingleOrDefault(x => x.Barkodas == pr.Barcode) == null)
                {
                    context.Preke.Add(new Preke() { Barkodas = pr.Barcode, Kaina = pr.Price, Atributai = (int)pr.Pattributes, Kategorija = (int)pr.Pcategory, Pavadinimas = pr.Pname, Svoris = pr.Weight });
                }
                context.SaveChanges();
            }
        }
        public bool isProductsWeightEqual() { return (scannedProductsWeight == productsWeight); }
        public bool isCardArrayEmpty()
        {
            if (creditCardsArray.Value.Array.Count == 0)
                return true;
            else return false;
        }
        private void addTare()
        {
            Scannedproductsarray.Add(Product.Tare);
            priceToPay += Product.Tare.Price;
        }
        public void addBag()
        {
            Scannedproductsarray.Add(Product.Bag);
            priceToPay += Product.Bag.Price;
        }
        public void ProductScanHandler(object sender, ProductScanEventArgs args)
        {
            if (!scannerOn) throw new PaymentStartedException();
            if (!isProductsWeightEqual()) throw new WeightEqualityException();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Preke WHERE Barkodas = @Bar", cn);
                cmd.Parameters.AddWithValue("@Bar", args.Barcode);
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count < 1)
                {
                    throw new EntryPointNotFoundException();
                }
                Product item = new Product(dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString(), (int)dt.Rows[0][3], (double)dt.Rows[0][2], (Category)(int)dt.Rows[0][4], (Attributes)(int)dt.Rows[0][5]);
                Scannedproductsarray.Add(item);
                if ((item.Pattributes.HasFlag(Attributes.NeedsApproval))) needsApproval = true;
                if (item.Pattributes.HasFlag(Attributes.PaidTare))
                    addTare();
                scannedProductsWeight += item.Weight;
                priceToPay += item.Price;
                }
            }
        public void ProductWeighHandler(object sender, ProductWeighEventArgs args)
        {
            if (isProductsWeightEqual()) throw new WeightEqualityException();
            productsWeight += args.Weight;
            if (!isProductsWeightEqual())
            {
                productsWeight -= args.Weight;
                throw new BadWeightException();
            }
        }
        // Jei sėkmingai 1
        // Jei
        // Jei nepatvirtinta darbuotojo -1
        //public int pay()
        //{
        //    if (needsApproval) return -1;
        //    if (isProductsWeightEqual())
        //    {
        //        return 1;
        //    }
        //    else return 0;
        //}

        // Jei sėkmingai 1
        // Jei kortelė nerasta duomenų bazėje 0
        // Jei nesėkmingai -1
        // Jei kortelė jau įdėta -2
        public int insertCard(string cardNumber)
        {
            if (payingCard == null)
            {
                if (payingMethod == PayingMethod.CreditCard)
                {
                    using (var context = new ShopDBEntities1())
                    {
                        var card = context.Mokejimo_kortele.SingleOrDefault(x => x.Id == cardNumber);
                        if (card == null)
                            return 0;
                        payingCard = new CreditCard(card.Id, card.Tipas, card.Bankas, card.Slaptažodžio_hash, card.Slaptažodžio_salt, card.Likutis);
                        return 1;
                    }
                }
                else return -1;
            }
            else return -2;
        }
        public void restorePayingMethod()
        {
            payingCard = null;
            payingMethod = PayingMethod.None;
        }
        // Teisingas true
        // Klaidingas false
        public bool isPasswordValid(string password)
        {
            if (payingCard.passwordEquals(password)) return true;
            else return false;
        }
        public void payWithCard()
        {
            payingMethod = PayingMethod.CreditCard;
        }
        public void payWithCash()
        {
            payingMethod = PayingMethod.Cash;
        }
        public bool insertMoney(Money money)
        {
            if (payingMethod == PayingMethod.Cash)
            {
                priceToPay -= (double)((int)money) / 100;
                priceToPay = Math.Round(priceToPay, 2);
                if (priceToPay < 0)
                {
                    change = -priceToPay;
                    priceToPay = 0;
                }
                return true;
            }
            else return false;
        }

        public void readProductData(string path)
        {
            FileReader fr = new FileReader();
            fr.ReadData(this, path);
            //Thread thread = new Thread(() => Productsdatabase.Read<Product>(fr, path));
            //thread.Start();
        }
        public void readFromInternet(string address)
        {
            InternetReader ir = new InternetReader();
            //Thread thread = new Thread(() => 
            ir.ReadData(this, address);
            //thread.Start();
        }
        public void addProductToDatabase(Product product)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand insert = cn.CreateCommand())
            {
                cn.Open();

                insert.Connection = cn;
                insert.CommandType = CommandType.Text;
                insert.CommandText = "INSERT INTO Preke (Barkodas, Pavadinimas, Kaina, Svoris, Kategorija, Atributai) VALUES (@Bar, @Pav, @Kai, @Svo, @Kat, @Atr)";

                insert.Parameters.Add(new SqlParameter("@Bar", SqlDbType.VarChar, 13, "Barkodas"));
                insert.Parameters.Add(new SqlParameter("@Pav", SqlDbType.VarChar, 50, "Pavadinimas"));
                insert.Parameters.Add(new SqlParameter("@Kai", SqlDbType.Float, 10, "Kaina"));
                insert.Parameters.Add(new SqlParameter("@Svo", SqlDbType.Int, 10, "Svoris"));
                insert.Parameters.Add(new SqlParameter("@Kat", SqlDbType.Int, 10, "Kategorija"));
                insert.Parameters.Add(new SqlParameter("@Atr", SqlDbType.Int, 10, "Atributai"));

                SqlDataAdapter da = new SqlDataAdapter("SELECT Barkodas, Pavadinimas, Kaina, Svoris, Kategorija, Atributai FROM Preke", cn);
                DataSet ds = new DataSet();

                da.Fill(ds, "Preke");

                da.InsertCommand = insert;


                DataRow newRow = ds.Tables[0].NewRow();
                newRow["Barkodas"] = product.Barcode;
                newRow["Pavadinimas"] = product.Pname;
                newRow["Kaina"] = product.Price;
                newRow["Svoris"] = product.Weight;
                newRow["Kategorija"] = (int)product.Pcategory;
                newRow["Atributai"] = (int)product.Pattributes;

                ds.Tables[0].Rows.Add(newRow);
                da.Update(ds.Tables[0]);
                da.Dispose();
            }
        }
        public void removeProductFromDatabase(string barcode)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand delete = cn.CreateCommand())
            {
                cn.Open();

                delete.Connection = cn;
                delete.CommandType = CommandType.Text;
                delete.CommandText = "DELETE FROM Preke WHERE Barkodas = @Bar";

                delete.Parameters.Add(new SqlParameter("@Bar", SqlDbType.VarChar, 13, "Barkodas")).Value = barcode;

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Preke", cn);
                DataSet ds = new DataSet();

                da.Fill(ds, "Preke");

                da.DeleteCommand = delete;
                da.DeleteCommand.ExecuteNonQuery();

                //da.Update(ds.Tables[0]);
                da.Dispose();
            }
        }
        public bool databaseContainsProduct(string barcode)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Preke WHERE Barkodas = @Bar", cn);
                cmd.Parameters.AddWithValue("@Bar", barcode);
                if ((int)cmd.ExecuteScalar() != 0) return true;
                else return false;
            }
        }
        public void updateProductInDatabase(Product product)
        {
            using (var context = new ShopDBEntities1())
            {
                Preke pr = context.Preke.SingleOrDefault(x => x.Barkodas == product.Barcode);
                pr.Barkodas = product.Barcode;
                pr.Kaina = product.Price;
                pr.Svoris = product.Weight;
                pr.Pavadinimas = product.Pname;
                pr.Kategorija = (int)product.Pcategory;
                pr.Atributai = (int)product.Pattributes;
                //context.Preke.Add(new Preke()
                //{
                //    Id = card.Number,
                //    Bankas = card.BankName,
                //    Tipas = card.Type,
                //    Slaptažodžio_hash = card.PasswordHash,
                //    Slaptažodžio_salt = card.PasswordSalt,
                //    Likutis = card.Balance
                //});
                context.ChangeTracker.DetectChanges();
                context.SaveChanges();
            }
        }
        public void addCreditCardToDatabase(CreditCard card)
        {
            using (var context = new ShopDBEntities1())
            {
                Mokejimo_kortele mk = new Mokejimo_kortele()
                {
                    Id = card.Number,
                    Bankas = card.BankName,
                    Tipas = card.Type,
                    Slaptažodžio_hash = card.PasswordHash,
                    Slaptažodžio_salt = card.PasswordSalt,
                    Likutis = card.Balance
                };
                if (context.Mokejimo_kortele.Any(x => x.Id == mk.Id)) return;
            
                context.Mokejimo_kortele.Add(mk);
                context.ChangeTracker.DetectChanges();
                context.SaveChanges();
                
                
            }
        }
        public void removeCreditCardFromDatabase(string id)
        {
            using (var context = new ShopDBEntities1())
            {
                var itemToRemove = context.Mokejimo_kortele.SingleOrDefault(x => x.Id == id);
                context.Mokejimo_kortele.Remove(itemToRemove);
                context.SaveChanges();
            }
        }
        public void chargeCreditCard(double totalPrice)
        {
            using (var context = new ShopDBEntities1())
            {
                var card = context.Mokejimo_kortele.SingleOrDefault(x => x.Id == PayingCard.Number);
                card.Likutis -= totalPrice;
                context.SaveChanges();
            }
            addPurchaseToDatabase();
        }
        public void addDiscountCard(Nuolaidu_kortele card)
        {
            using (var context = new ShopDBEntities1())
            {
                context.Nuolaidu_kortele.Add(card);
                context.SaveChanges();
            }
        }
        public void removeDiscountCard(string id)
        {
            using (var context = new ShopDBEntities1())
            {
                var cardToRemove = context.Nuolaidu_kortele.SingleOrDefault(x => x.ID == id);
                context.Nuolaidu_kortele.Remove(cardToRemove);
                context.SaveChanges();
            }
        }
        public void addPurchaseToDatabase()
        {
            using (var context = new ShopDBEntities1())
            {
                var pirkimas = new Pirkimas();
                if (payingMethod == PayingMethod.Cash)
                {
                    pirkimas.Apmokejimo_tipas = "Grynais";
                    context.Pirkimas.Add(pirkimas);
                }
                else 
                {
                    pirkimas.Apmokejimo_tipas = "Kortele";
                    pirkimas.Mokejimo_kortele = PayingCard.Number;
                    context.Pirkimas.Add(pirkimas);
                }
                context.SaveChanges();

                foreach (var product in Scannedproductsarray)
                {
                    var updatePirkimo_prekes = context.Pirkimo_prekes.SingleOrDefault(x => (x.Preke == product.Barcode) && (x.Pirkimas == pirkimas.Id));
                    if (updatePirkimo_prekes == null)
                    {
                        context.Pirkimo_prekes.Add(new Pirkimo_prekes() { Pirkimas = pirkimas.Id, Preke = product.Barcode, Kiekis = 1 });
                        context.SaveChanges();
                    }
                    else
                    {
                        updatePirkimo_prekes.Kiekis += 1;
                        context.SaveChanges();
                    }
                }
                context.ChangeTracker.DetectChanges();
                context.SaveChanges();
            }
        }
    }
    [Serializable]
    class PaymentStartedException : Exception { }
    [Serializable]
    class WeightEqualityException : Exception { }
    [Serializable]
    class BadWeightException : Exception { }
}
