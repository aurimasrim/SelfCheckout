using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

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
        public CustomArray<Product> Productsdatabase { get; set; }
        public CustomArray<Product> Scannedproductsarray { get; set; }
        private Lazy<CreditCardArray> creditCardsArray;
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
            Productsdatabase = new CustomArray<Product>();
            Scannedproductsarray = new CustomArray<Product>();
            payingMethod = PayingMethod.None;
            //creditCardsArray = new CustomArray<CreditCard>();
            creditCardsArray = new Lazy<CreditCardArray>(() => new CreditCardArray(cardPath));
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
            foreach (Product item in Productsdatabase)
            {
                if (args.Barcode.Equals(item.Barcode))
                {
                    Product clone;
                    if ((item.Pattributes.HasFlag(Attributes.Alcohol)))
                    {
                        needsApproval = true;
                        //if (discountTime == true)
                        //{
                        //    clone = (Product)item.CloneWithDiscount(20);
                        //    Scannedproductsarray.add(clone);
                        //}
                        //else
                        //{
                        clone = (Product)item.Clone();
                        Scannedproductsarray.Add(clone);
                        //}
                    }
                    else
                    {
                        clone = (Product)item.Clone();
                        Scannedproductsarray.Add(clone);
                    }
                    if (item.Pattributes.HasFlag(Attributes.PaidTare))
                        addTare();
                    scannedProductsWeight += item.Weight;
                    priceToPay += clone.Price;
                    return;
                }
            }
            throw new EntryPointNotFoundException();
        }
        // Jei sėkmingai nuskenuoja 1 
        // Jei produkto nėra duomenų bazėje 0
        // Jei negalima skenuoti nes nepasverta paskutinė prekė -1
        // Jei negalima, nes pradėtas apmokėjimas -2
        public int scan(string barcode)
        {
            TimeSpan start = new TimeSpan(8, 0, 0);
            TimeSpan end = new TimeSpan(18, 0, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;
            bool discountTime = false;
            if ((now >= start) && (now <= end))
            {
                discountTime = true;
            }
            if (scannerOn)
            {
                if (isProductsWeightEqual())
                {
                    foreach (Product item in Productsdatabase)
                    {
                        if (barcode.Equals(item.Barcode))
                        {
                            Product clone;
                            if ((item.Pattributes.HasFlag(Attributes.Alcohol)))
                            {
                                needsApproval = true;
                                if (discountTime == true)
                                {
                                    clone = (Product)item.CloneWithDiscount(20);
                                    Scannedproductsarray.Add(clone);
                                }
                                else
                                {
                                    clone = (Product)item.Clone();
                                    Scannedproductsarray.Add(clone);
                                }
                            }
                            else
                            {
                                clone = (Product)item.Clone();
                                Scannedproductsarray.Add(clone);
                            }
                            if (item.Pattributes.HasFlag(Attributes.PaidTare))
                                addTare();
                            scannedProductsWeight += item.Weight;
                            priceToPay += clone.Price;
                            return 1;
                        }
                    }
                    return 0;
                }
                else return -1;
            }
            else return -2;
        }
        // Jei sėkmingai pasveria 1
        // Jei nereikėjo sverti 0
        // Jei nesutampa svoriai -1
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
        // Jei kortelė nerasta duomenų bazėje
        // Jei nesėkmingai -1
        // Jei kortelė jau įdėta
        public int insertCard(string cardNumber)
        {
            if (payingCard == null)
            {
                if (payingMethod == PayingMethod.CreditCard)
                {
                    foreach (CreditCard item in creditCardsArray.Value)
                    {
                        if (cardNumber == item.Number)
                        {
                            payingCard = item;
                            return 1;
                        }
                    }
                    return 0;
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
            //Thread thread = new Thread(() => Productsdatabase.Read<Product>(fr, path));
            //thread.Start();
            Productsdatabase.Read<Product>(fr, path);
        }
        public void writeCardData(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<string> allLines = new List<string>();
            string line = null;
            foreach (CreditCard item in creditCardsArray.Value)
            {
                line = sr.ReadLine();
                line = System.Text.RegularExpressions.Regex.Replace(line, @"/\d+(,\d)?\d?$", "/" + item.Balance.ToString());

                allLines.Add(line);
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(path);
            foreach (string item in allLines)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }
        public void readFromInternet(string address)
        {
            InternetReader ir = new InternetReader();
            //Thread thread = new Thread(() => 
            Productsdatabase.Read<Product>(ir, address);
            //thread.Start();
        }
    }
    [Serializable]
    class PaymentStartedException : Exception { }
    [Serializable]
    class WeightEqualityException : Exception { }
    [Serializable]
    class BadWeightException : Exception { }
}
