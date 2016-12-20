using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;

namespace WindowsFormsApplication3
{
    partial class CameraScanForm : Form
    {
        Point mouseDownPoint = Point.Empty;
        CheckoutForm f1;
        ClientForm f2;
        bool ForAdding;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public CameraScanForm(CheckoutForm f1, ClientForm f2, bool forAdding)
        {
            InitializeComponent();
            this.f1 = f1;
            this.f2 = f2;
            ForAdding = forAdding;

            //comboCategories.DataSource = Enum.GetNames(typeof(Attributes));
            
        }

        private void CameraScanForm_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach (FilterInfo device in videoDevices)
            //{
            //    comboDevices.Items.Add(device.Name);
            //}
            //comboDevices.SelectedIndex = 0;

            videoSource = new VideoCaptureDevice();
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame;
            videoSource.Start();
            timer.Start();
            //Task.Delay(5000);
            //videoSource.Stop();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            pictureBoxVideo.Image = (Bitmap)image;
        }

        private string GetBarcodeFromImage(Bitmap image)
        {
            BarcodeReader reader = new BarcodeReader(null, newbitmap => new BitmapLuminanceSource(image), luminance => new GlobalHistogramBinarizer(luminance));
            reader.AutoRotate = true;
            reader.TryInverted = true;
            reader.Options = new DecodingOptions { TryHarder = true };
            Result result = null;
            if (image != null)
            {
                 result = reader.Decode(image);
            }
            
            if (result != null)
            {
                return result.Text;
            }
            else
            {
                return null;
            }
                
        }
        private Task <string> GetBarcodeAsync(Bitmap image)
        {
            return Task.Run(() => GetBarcodeFromImage(image));
        }

        private void CameraScan_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void CameraScan_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void CameraScan_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint.IsEmpty) return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
        }

        private void CameraScanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
        }

        private void CameraScanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void timer_Tick(object sender, EventArgs e)
        {
            //Thread decodeThread = new Thread(new ThreadStart(delegate ()
            //{
            string barcode = null;
            try
            {
                barcode = await GetBarcodeAsync((Bitmap)pictureBoxVideo.Image);
            }
            catch (ArgumentNullException) { }

            if (barcode != null)
            {
                timer.Stop();
                videoSource.Stop();

                if (ForAdding)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(barcode, @"^\d{8}$|^\d{13}$"))
                    {
                        AddProductForm apf = new AddProductForm(f1, f2, f1.adminWindow, barcode);
                        apf.ShowDialog();
                        this.Close();
                    }
                    else if (System.Text.RegularExpressions.Regex.IsMatch(barcode, @"^\d+$"))
                    {
                        if (f1.cm.addDiscountCard(new Nuolaidu_kortele() { Id = barcode }))
                            MessageBoxForm.Show("Nuolaidų kortelė pridėta");
                        else MessageBoxForm.Show("Nuolaidų kortelė tokiu numeriu jau yra");
                        this.Close();
                    }
                    else
                    {
                        try
                        {
                            AddFromQRcode(barcode);
                        }
                        catch (Exception)
                        {
                            MessageBoxForm.Show("Nepavyko atidaryti tinklapio");
                        }
                        finally
                        {
                            this.Close();
                        }
                    }
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(barcode, @"^\d{8}$|^\d{13}$"))
                {
                    f2.OnProductScan(this, new ProductScanEventArgs(barcode));
                    this.Close();
                    new CameraScanForm(f1, f2, false).Show();

                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(barcode, @"^\d+$"))
                {
                    if (f1.cm.insertDiscountCard(barcode))
                    {
                        MessageBoxForm.Show("Kortelė sėkmingai įdėta");
                        f1.bindData();
                    }
                    else MessageBoxForm.Show("Kortelė nerasta duomenų bazėje");
                    this.Close();
                }
                else
                {
                    MessageBoxForm.Show("Norėdami pridėti prekę pagal QR kodą, tai darykite valdytojo lange");
                    this.Close();
                }
                    
            }
            //}));
            //decodeThread.Start();
        }

        private void AddFromQRcode(string address)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            wc.Encoding = Encoding.UTF8;
            string webdata = wc.DownloadString(address);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(webdata);
            var node = doc.DocumentNode.SelectSingleNode("//head//title");

            Random rnd = new Random();
            int barcode;
            //MessageBox.Show(barcode.ToString());
            for (;;)
            {

                barcode = rnd.Next(10000000, 99999999);
                if (!f1.cm.databaseContainsProduct(barcode.ToString()))
                    break;
            }
            double price = (double)rnd.Next(25, 1500) / 100;
            Product product = new Product(node.InnerText, barcode.ToString(), rnd.Next(50, 5000), price, Category.Kita) ;
            f1.cm.addProductToDatabase(product);
            f1.adminWindow.GetData();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (ForAdding)
                this.Close();
            else
            {
                if (videoSource.IsRunning)
                {
                    videoSource.Stop();
                }
                this.Hide();
            }
        }

        private void CameraScanForm_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible)
            {
                if (!videoSource.IsRunning)
                {
                    videoSource.Start();
                }
            }
        }
    }
}
