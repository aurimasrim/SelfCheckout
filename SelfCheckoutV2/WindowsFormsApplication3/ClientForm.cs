using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    partial class ClientForm : Form
    {
        Point mouseDownPoint = Point.Empty;
        CheckoutForm f1;
        public ClientForm(CheckoutForm f1)
        {
            InitializeComponent();
            this.f1 = f1;
            //gridProducts.DataSource = productBindingSource;

            //spalvos
            DataGridViewButtonColumn c = (DataGridViewButtonColumn)gridProducts.Columns["scanProduct"];
            c.FlatStyle = FlatStyle.Popup;
            c = (DataGridViewButtonColumn)gridProducts.Columns["putProduct"];
            c.FlatStyle = FlatStyle.Popup;

            // 2 skaičiai po kablelio
            gridProducts.Columns[1].DefaultCellStyle.Format = "N2";
        }
        public event EventHandler<ProductScanEventArgs> ProductScan;
        public event EventHandler<ProductWeighEventArgs> ProductWeigh;
        public void OnProductScan(object sender, ProductScanEventArgs args)
        {
            try
            {
                ProductScan(sender, args);

                gridProducts.ClearSelection();
            }
            catch (NullReferenceException)
            {
                MessageBoxForm.Show("Jūsų pasirinkta prekė neturi barkodo");
            }
            catch (PaymentStartedException)
            {
                MessageBoxForm.Show("Nebegalite skenuoti prekių, nes pradėjote apmokėjimą\nSpauskite atgal");
            }
            catch (WeightEqualityException)
            {
                MessageBoxForm.Show("Pirma padėkite paskutinę nuskenuotą prekę");
            }
            catch (EntryPointNotFoundException)
            {
                MessageBoxForm.Show("Produktas nerastas duomenų bazėje");
            }
        }
        public void ResetBindings(bool value)
        {
            if (InvokeRequired)
            {
                Action<bool> resetBindingsCallBack = new Action <bool> (ResetBindings);
                this.Invoke(resetBindingsCallBack, value);
            }
            //else productBindingSource.ResetBindings(value);
        }
        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridProducts.Columns[e.ColumnIndex].Name == "scanProduct")
                {
                    try
                    {
                        //MessageBoxForm.Show(f1.cm.Productsdatabase.Array[e.RowIndex].Barcode);
                        //string bar = f1.cm.Productsdatabase.Array[e.RowIndex].Barcode;
                        ProductScan(this, new ProductScanEventArgs(gridProducts.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        
                        //f1.scan(f1.cm.Productsdatabase.Array[e.RowIndex].Barcode);
                        gridProducts.ClearSelection();
                        gridProducts.Rows[e.RowIndex].Cells[5].Selected = true;
                    }
                    catch (NullReferenceException)
                    {
                        MessageBoxForm.Show("Jūsų pasirinkta prekė neturi barkodo");
                    }
                    catch (PaymentStartedException)
                    {
                        MessageBoxForm.Show("Nebegalite skenuoti prekių, nes pradėjote apmokėjimą\nSpauskite atgal");
                    }
                    catch (WeightEqualityException)
                    {
                        MessageBoxForm.Show("Pirma padėkite paskutinę nuskenuotą prekę");
                    }
                    catch (EntryPointNotFoundException)
                    {
                        MessageBoxForm.Show("Produktas nerastas duomenų bazėje");
                    }
                }
                else if (gridProducts.Columns[e.ColumnIndex].Name == "putProduct")
                {
                    //f1.weigh(f1.cm.Productsdatabase.Array[e.RowIndex].Weight);
                    try
                    {
                        ProductWeigh(this, new ProductWeighEventArgs((int)gridProducts.Rows[e.RowIndex].Cells[3].Value));
                    }
                    catch (WeightEqualityException)
                    {
                        MessageBoxForm.Show("Pirma nuskenuokite prekę");
                    }
                    catch (BadWeightException)
                    {
                        MessageBoxForm.Show("Pasvėrėte ne tą prekę");
                    }
                }
            }
            catch (ArgumentOutOfRangeException) { }
        }
        private void buttonInsertCard_Click(object sender, EventArgs e)
        {
            f1.insertCard(textBoxCardNumber.Text);
        }

        private void picture1Cent_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M1cent);
        }

        private void picture2Cents_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M2cents);
        }

        private void picture5Cents_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M5cents);
        }

        private void picture10Cents_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M10cents);
        }

        private void picture20Cents_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M20cents);
        }

        private void picture50Cents_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M50cents);
        }

        private void picture1Euro_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M1euro);
        }

        private void picture2Euros_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M2euros);
        }

        private void picture5Euros_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M5euros);
        }

        private void picture10Euros_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M10euros);
        }

        private void picture20Euros_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M20euros);
        }

        private void picture50Euros_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M50euros);
        }

        private void picture100Euros_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M100euros);
        }

        private void picture200Euros_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M200euros);
        }

        private void picture500Euros_Click(object sender, EventArgs e)
        {
            f1.insertMoney(Money.M500euros);
        }

        private void ClientForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void ClientForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void ClientForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint.IsEmpty) return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //productBindingSource.ResetBindings(false);
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prekeDataSet.Preke' table. You can move, or remove it, as needed.
            //this.prekeTableAdapter.Fill(this.prekeDataSet.Preke);
            this.gridProducts.DataSource = f1.adminWindow.gridProducts.DataSource;
        }
    }
}
