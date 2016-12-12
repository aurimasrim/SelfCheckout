using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    partial class PayForm : Form
    {
        Point mouseDownPoint = Point.Empty;
        CheckoutForm f1;
        public PayForm(CheckoutForm f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        public void modeBags ()
        {
            label3.Text = "Kiek maišelių panaudojote?";
            label3.Visible = true;
            label2.Visible = false;
            label1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            buttonCard.Visible = false;
            buttonCash.Visible = false;
            boxTotal.Visible = false;
            textBagCount.Visible = true;
            buttonOk.Visible = true;
            buttonValidate.Visible = false;
            textBoxPassword.Visible = false;
        }
        public void modePayMethods ()
        {
            label3.Text = "Pasirinkite mokėjimo būdą";
            label3.Visible = true;
            label2.Visible = false;
            label1.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            buttonCard.Visible = true;
            buttonCash.Visible = true;
            boxTotal.Visible = false;
            textBagCount.Visible = false;
            buttonOk.Visible = false;
            buttonValidate.Visible = false;
            textBoxPassword.Visible = false;
        }
        public void modeCard()
        {
            label3.Visible = false;
            label2.Visible = true;
            label1.Text = "Įdėkite kortelę ir įveskite slaptažodį";
            label1.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            buttonCard.Visible = false;
            buttonCash.Visible = false;
            boxTotal.Visible = true;
            textBagCount.Visible = false;
            buttonOk.Visible = false;
            textBoxPassword.Visible = true;
            buttonValidate.Visible = true;
        }
        public void modeCash()
        {
            label3.Visible = false;
            label2.Visible = true;
            label1.Text = "Dėkite pinigus į tam skirtas vietas";
            label1.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            buttonCard.Visible = false;
            buttonCash.Visible = false;
            boxTotal.Visible = true;
            textBagCount.Visible = false;
            buttonOk.Visible = false;
            textBoxPassword.Visible = false;
            buttonValidate.Visible = false;
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if (f1.cm.PayingCard != null)
            {
                if (new PasswordTool().ComparePasswordToHash(textBoxPassword.Text, f1.cm.PayingCard.PasswordSalt, f1.cm.PayingCard.PasswordHash))
                {
                    if (f1.cm.PayingCard.Balance >= f1.cm.PriceToPay)
                    {
                        f1.cm.chargeCreditCard(f1.cm.PriceToPay);
                        
                        MessageBoxForm.Show("Sėkmingai apmokėta. Paimkite prekes.\nGeros dienos!");
                        f1.Close();
                    }
                    else
                    {
                        MessageBoxForm.Show("Nepakankamas sąskaitos likutis\nPasirinkite kitą mokėjimo būdą arba įdėkite kitą kreditinę kortelę");
                        buttonBack_Click(sender, e);
                    }        
                }
                else MessageBoxForm.Show("Neteisingas slaptažodis");
            }
            else MessageBoxForm.Show("Įdėkite kreditinę kortelę");
            textBoxPassword.Clear();
        }

        private void PayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Close();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (label1.Visible == false)
            {
                this.Hide();
                f1.Show();
                f1.cm.scannerOn = true;
            }
            else
            {
                modePayMethods();
                if (f1.cm.PayingCard != null)
                {
                    MessageBoxForm.Show("Kortelė išimta");
                }
                f1.cm.restorePayingMethod();
            }
        }

        private void PayForm_VisibleChanged(object sender, EventArgs e)
        {
            boxTotal.Text = f1.cm.PriceToPay.ToString("0.00");
            f1.boxTotal.Text = f1.cm.PriceToPay.ToString("0.00");
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            modeCard();

            f1.cm.payWithCard();
        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
            modeCash();
            
            f1.cm.payWithCash();
        }

        private void PayForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void PayForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void PayForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint.IsEmpty) return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            int i;
            int n = int.Parse(textBagCount.Text);
            for (i = 0; i < n; i++)
            {
                f1.addBag();
            }
            modePayMethods();
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxPassword.Text, @"^\d{4}$"))
            {
                e.Cancel = true;
                textBoxPassword.BackColor = Color.Red;
            }
        }

        private void textBoxPassword_Validated(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.LightBlue;
        }
    }
}
