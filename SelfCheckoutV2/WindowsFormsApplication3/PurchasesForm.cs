using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    partial class PurchasesForm : Form
    {
        CheckoutForm f1;
        ClientForm f2;
        AdminForm f3;
        public PurchasesForm(CheckoutForm f1, ClientForm f2, AdminForm f3)
        {
            this.f1 = f1;
            this.f2 = f2;
            this.f3 = f3;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreditCardsForm_Load(object sender, EventArgs e)
        {
            gridPurchases.DataSource = pirkimasBindingSource;
            GetData();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCreditCardForm accf = new AddCreditCardForm(f1, f2, f3);
            accf.ShowDialog();
        }
        public void GetData()
        {
            using (var context = new ShopDBEntities1())
            {
                //context.Pirkimas.Join(context.Pirkimo_prekes, p => p.Id, pp => pp.Pirkimas, (p, pp) => new { p.Id, p.});
                var first = from z in context.Pirkimo_prekes
                            join w in context.Preke
                            on z.Preke equals w.Barkodas
                            select new
                            {
                                z.Pirkimas,
                                z.Kiekis,
                                w.Barkodas,
                                w.Kaina
                            };
                var second = from x in first
                             group x by x.Pirkimas into g
                             select new
                             {
                                 g.Key,
                                 Suma = g.Sum(y => y.Kaina * y.Kiekis)
                             };
                var third = from x in context.Pirkimas
                            join y in second
                            on x.Id equals y.Key into pp
                            from p in pp.DefaultIfEmpty()
                            select new
                            {
                                x.Id,
                                x.Data,
                                x.Apmokejimo_tipas,
                                x.Mokejimo_kortele,
                                x.Nuolaidu_kortele,
                                Suma = p == null ? 0 : p.Suma
                            };
                pirkimasBindingSource.DataSource = third.ToList();

                //select new
                //{
                //    q.Sum(q.)
                //}

                //var joined = from x in context.Pirkimas
                //             join y in 
                //             on x.Id equals y.Pirkimas
                //             select new
                //             {
                //                 x.Id,
                //                 x.Data,
                //                 x.Nuolaidu_kortele,
                //                 x.Apmokejimo_tipas,
                //                 x.Mokejimo_kortele,
                //                 y.Preke 
                //             }



            }
            //using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aurimas\Documents\GitHub\SelfCheckout\SelfCheckoutV2\WindowsFormsApplication3\ShopDB.mdf;Integrated Security=True"))
            //{
            //    cn.Open();

            //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pirkimas", cn);
            //    DataTable purchasesTable = new DataTable();
            //    purchasesTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
            //    da.Fill(purchasesTable);
            //    da.SelectCommand = new SqlCommand("SELECT * FROM Pirkimo_prekes");
            //    DataTable purchasesProductsTable = new DataTable();
            //    da.Fill(purchasesProductsTable);

            //    var result = from p in purchasesTable.AsEnumerable()
            //                 join pp in purchasesProductsTable.AsEnumerable()
            //                 on p.Field<string>("Id") equals pp.Field<string>("Pirkimas")
            //                 select new { p.Field<string>("Id") };


            //    pirkimasBindingSource.DataSource = dt;
            //    da.Dispose();
            //    //gridProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            //}
        }

        private void gridCards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridPurchases.Columns[e.ColumnIndex].Name == "remove")
            {
                f1.cm.removeCreditCardFromDatabase(gridPurchases.Rows[e.RowIndex].Cells[0].Value.ToString());
                GetData();
                //df.Show();
                //this.ResetBindings(true);
                //f2.ResetBindings(true);
            }
        }
    }
}
