using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace WindowsFormsApplication3
{
    partial class AdminForm : Form
    {
        Point mouseDownPoint = Point.Empty;
        CheckoutForm f1;
        ClientForm f2;
        CameraScanForm csf;
        public CreditCardsForm ccf;
        public AdminForm(CheckoutForm f1, ClientForm f2)
        {
            InitializeComponent();
            this.f1 = f1;
            this.f2 = f2;
            

            buttonClose.Click += delegate (object sender, EventArgs e)
            {
                f1.Close();
            };
            // 2 skaičiai po kablelio
            gridProducts.Columns[1].DefaultCellStyle.Format = "N2";

            comboCategories.DataSource = Enum.GetNames(typeof(Category));
            comboCategories.SelectedIndex = 0;
        }
        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            string path = f1.getPath();
            Thread thread = new Thread(() =>
            {
                Monitor.Enter(f1.cm.Productsdatabase);
                try
                {
                    f1.cm.readProductData(path);
                    //this.ResetBindings(true);
                    //f2.ResetBindings(true);
                }
                catch (IOException)
                {
                    MessageBoxForm.Show("Blogi failo duomenys");
                }
                catch (ArgumentNullException) { }
                finally
                {
                    Monitor.Exit(f1.cm.Productsdatabase);
                }
            });
            thread.Start();
        }

        private void buttonReadInternet_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(f1, f2, this);
            addressForm.ShowDialog();
        }

        //private void buttonReadCredit_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        f1.cardPath = f1.getPath();
        //        if (f1.cardPath != null) f1.cm.readCardData(f1.cardPath);
        //    }
        //    catch (IOException)
        //    {
        //        MessageBoxForm.Show("Blogi failo duomenys");
        //    }
        //}

        //private void buttonClose_Click(object sender, EventArgs e)
        //{
        //    f1.Close();
        //}

        private void AdminForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void AdminForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void AdminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint.IsEmpty) return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Close();
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            f1.approveAge();
        }

        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProducts.Columns[e.ColumnIndex].Name == "makeDiscount")
            {
                DiscountForm df = new DiscountForm(f1,f2, this, e.RowIndex);
                df.Show();
                //this.ResetBindings(true);
                //f2.ResetBindings(true);
            }
            else if (gridProducts.Columns[e.ColumnIndex].Name == "removeProduct")
            {
                f1.cm.removeProductFromDatabase(gridProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
                GetData();
                //this.ResetBindings(true);
                //f2.ResetBindings(true);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            f1.cm.Productsdatabase.Sort();
            //this.ResetBindings(true);
            //f2.ResetBindings(true);
        }

        private void buttonDiscount_Click(object sender, EventArgs e)
        {
            Attributes category = Attributes.None;
            switch (comboCategories.SelectedIndex)
            {
                case 0:
                    category = Attributes.Alcohol;
                    break;
                case 1:
                    category = Attributes.Drink;
                    break;
            }
            
            for(int i = 0; i < f1.cm.Productsdatabase.getSize(); i++)
            {
                if (f1.cm.Productsdatabase[i].Pattributes.HasFlag((Attributes)Enum.Parse(typeof(Attributes), category.ToString())))
                {
                    f1.cm.Productsdatabase.Replace(i, (Product)f1.cm.Productsdatabase[i].CloneWithDiscount(int.Parse(textBoxDiscount.Text)));
                    f1.cm.Productsdatabase[i].AddAttribute(Attributes.HaveDiscount);
                }
            
            }
            //this.ResetBindings(true);
            //f2.ResetBindings(true);
        }
        private void textBoxDiscount_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxDiscount.Text, @"^[1-9]\d?$"))
            {
                e.Cancel = true;
                textBoxDiscount.BackColor = Color.Red;
            }
        }

        private void textBoxDiscount_Validated(object sender, EventArgs e)
        {
            textBoxDiscount.BackColor = Color.LightBlue;
        }

        private void buttonScanWithCamera_Click(object sender, EventArgs e)
        {
            csf = new CameraScanForm(f1, f2, true);
            csf.ShowDialog();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm adf = new AddProductForm(f1, f2, this);
            adf.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prekeDataSet.Preke' table. You can move, or remove it, as needed.
            //this.prekeTableAdapter.Fill(this.prekeDataSet.Preke);
            this.GetData();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aurimas\Documents\GitHub\SelfCheckout\SelfCheckoutV2\WindowsFormsApplication3\ShopDB.mdf;Integrated Security=True"))
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT Barkodas, Pavadinimas, Kaina, Svoris, Kategorija, Atributai FROM Preke", cn);
                DataTable dt = new DataTable();
                dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                da.Fill(dt);
                prekeBindingSource.DataSource = dt;
                da.Dispose();
                gridProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            }
        }

        private void buttonCreditCards_Click(object sender, EventArgs e)
        {
            ccf = new CreditCardsForm(f1, f2, this);
            ccf.ShowDialog();
        }
    }
}
