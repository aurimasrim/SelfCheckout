using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Configuration;

namespace WindowsFormsApplication3
{
    partial class CheckoutForm : Form
    {
        Point mouseDownPoint = Point.Empty;
        private SoundPlayer beep = new SoundPlayer(String.Concat(Directory.GetCurrentDirectory(), @"\beep-08b.wav"));
        private SoundPlayer coin = new SoundPlayer(String.Concat(Directory.GetCurrentDirectory(), @"\smw_coin.wav"));
        public CheckoutMachine cm = new CheckoutMachine();
        public PayForm payWindow;
        public ClientForm testingWindow;
        public AdminForm adminWindow;
        HelpForm helpForm;
        CameraScanForm csf;
        public CheckoutForm()
        {
            InitializeComponent();
            string colorName = ConfigurationManager.AppSettings["ButtonsColor"]; // java config.properties
            Color color = Color.FromName(colorName);
            buttonPay.BackColor = color;
            buttonSearch.BackColor = color;
            testingWindow = new ClientForm(this);

            testingWindow.ProductScan += cm.ProductScanHandler;
            testingWindow.ProductScan += this.ProductScanEventHandler;

            testingWindow.ProductWeigh += cm.ProductWeighHandler;
            testingWindow.ProductWeigh += this.ProductWeighEventHandler;

            adminWindow = new AdminForm(this, testingWindow);

            payWindow = new PayForm(this);
            
            helpForm = new HelpForm(this, testingWindow, adminWindow);
            helpForm.Show();

            csf = new CameraScanForm(this, testingWindow, false);

            // 2 skaičiai po kablelio
            gridScannedProducts.Columns[1].DefaultCellStyle.Format = "N2";
            boxTotal.Text = cm.PriceToPay.ToString("0.00");
        }
        public void weigh (int weight)
        {
            gridScannedProducts.ClearSelection();
        }
        public void insertCard(string cardNumber)
        {
            int res = cm.insertCard(cardNumber);
            if (res == 1) MessageBoxForm.Show("Kortelė sėkmingai įdėta");
            else if (res == 0) MessageBoxForm.Show("Kortelė nerasta duomenų bazėje");
            else if (res == -1) MessageBoxForm.Show("Pirma paspauskite mokėti ir pasirinkite mokėjimo būdą kreditine kortele");
            else MessageBoxForm.Show("Kortelė jau įdėta");
        }
        public void insertMoney(Money money)
        {
            if(cm.insertMoney(money))
            {
                playCoin();
                payWindow.boxTotal.Text = cm.PriceToPay.ToString("0.00");
                if (cm.PriceToPay == 0)
                {
                    if (cm.Change != 0) MessageBoxForm.Show("Paimkite grąžą: " + cm.Change.ToString("0.00"));
                    MessageBoxForm.Show("Geros dienos!");
                    cm.addPurchaseToDatabase();
                    this.Close();
                }
            }
            else
            {
                MessageBoxForm.Show("Pirma paspauskite mokėti ir pasirinkite mokėjimo būdą grynais");
            }
            
        }
        public void addBag()
        {
            cm.addBag();
            bindData();
        }
        public void approveAge()
        {
            cm.isAgeApproved = true;
            labelApproval.Hide();
        }
        public string getPath()
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "|*.txt";
            filedialog.CheckFileExists = true;
            filedialog.CheckPathExists = true;
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                return filedialog.FileName;
            }
            else return null;
        }
        public void ProductScanEventHandler (object sender, ProductScanEventArgs args)
        {
            playBeep();
            bindData();
            int lastrow = gridScannedProducts.RowCount - 1;
            gridScannedProducts.ClearSelection();
            if (gridScannedProducts.Rows[lastrow].Cells[0].Value.Equals("Butelio tara"))
            {
                gridScannedProducts.Rows[lastrow - 1].Selected = true;
            }
            gridScannedProducts.Rows[lastrow].Selected = true;

            if ((cm.needsApproval) && (!cm.isAgeApproved))
            {
                labelApproval.Show();
            }
        }
        public void ProductWeighEventHandler (object sender, ProductWeighEventArgs args)
        {
            gridScannedProducts.ClearSelection();
            testingWindow.gridProducts.ClearSelection();
        }
        public void bindData()
        {
            gridScannedProducts.DataSource = null;
            gridScannedProducts.DataSource = cm.Scannedproductsarray.Array;

            int lastrow = gridScannedProducts.RowCount - 1;

            // kad automatiškai scroll'intų į apačią
            gridScannedProducts.FirstDisplayedScrollingRowIndex = lastrow;

           

            boxTotal.Text = cm.PriceToPay.ToString("0.00");
            payWindow.boxTotal.Text = cm.PriceToPay.ToString("0.00");
        }
        public void playBeep() { beep.Play(); }
        public void playCoin() { coin.Play(); }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (cm.isProductsWeightEqual() == true)
            {
                BarcodeForm barcodeForm = new BarcodeForm(this);
                barcodeForm.ShowDialog();

            }
            else MessageBoxForm.Show("Pirma padėkite paskutinę prekę");
        }
        private void buttonPay_Click(object sender, EventArgs e)
        {
            if ((!cm.isAgeApproved) && (cm.needsApproval)) MessageBoxForm.Show("Reikia patvirtinimo tu mažas alkoholike!");
            else if (cm.PriceToPay != 0)
            {
                if (!cm.isProductsWeightEqual())
                {
                    MessageBoxForm.Show("Pirma padėkite paskutinę nuskenuotą prekę");
                }
                else
                {
                    payWindow.Show();
                    cm.scannerOn = false;
                    this.Hide();
                }
            }
            else MessageBoxForm.Show("Nenuskenavote jokių prekių");
        }
        // Uždarant programą
        private void CheckoutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if ((cm.cardPath != null)&&(!cm.isCardArrayEmpty())) cm.writeCardData(cm.cardPath);
        }

        private void CheckoutForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void CheckoutForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void CheckoutForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint.IsEmpty) return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
        }

        private void buttonScanWithCamera_Click(object sender, EventArgs e)
        {
            if (!csf.Visible)
            {
                csf.Show();
            }
        }
    }
    
}
