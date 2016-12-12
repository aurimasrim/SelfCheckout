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
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    partial class AddCreditCardForm : Form
    {
        CheckoutForm f1;
        ClientForm f2;
        AdminForm f3;
        string Barcode;
        Attributes attributes = Attributes.None;
        public AddCreditCardForm(CheckoutForm f1, ClientForm f2, AdminForm f3)
        {
            this.f1 = f1;
            this.f2 = f2;
            this.f3 = f3;
            InitializeComponent();
        }
        public AddCreditCardForm(CheckoutForm f1, ClientForm f2, AdminForm f3, string barcode)
        {
            this.f1 = f1;
            this.f2 = f2;
            this.f3 = f3;
            Barcode = barcode;
            InitializeComponent();

            textBoxBalance.ReadOnly = true;
            textBoxBalance.BackColor = Color.DarkViolet;
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            textBoxBalance.Text = Barcode;
            
            
        }
        private void enumCheckedChanged (object sender, EventArgs args)
        {
            var checkBox = (CheckBox)sender;
            var attribute = (Attributes)checkBox.Tag;
            if (checkBox.Checked) attributes |= attribute;
            else attributes ^= attribute;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            PasswordTool pt = new PasswordTool();
            string salt = pt.getNewSalt();
            string hash = pt.GetStringHash(textBoxPassword.Text, salt);
            f1.cm.addCreditCardToDatabase(new CreditCard(textBoxId.Text, textBoxType.Text, textBoxBank.Text, hash, salt, double.Parse(textBoxBalance.Text)));
            f3.ccf.GetData();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxBarcode_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxBalance.Text, @"^\d+(,\d+)?$"))
            {
                e.Cancel = true;
                textBoxBalance.BackColor = Color.Red;
            }
        }
        private void textBoxBarcode_Validated(object sender, EventArgs e)
        {
            textBoxBalance.BackColor = Color.LightBlue;
        }

        private void textBoxWeight_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxBank.Text, @"^.+$"))
            {
                e.Cancel = true;
                textBoxBank.BackColor = Color.Red;
            }
        }

        private void textBoxWeight_Validated(object sender, EventArgs e)
        {
            textBoxBank.BackColor = Color.LightBlue;
        }

        private void textBoxPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxType.Text, @"^.+$"))
            {
                e.Cancel = true;
                textBoxType.BackColor = Color.Red;
            }
        }

        private void textBoxPrice_Validated(object sender, EventArgs e)
        {
            textBoxType.BackColor = Color.LightBlue;
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxId.Text, @"^\d+$"))
            {
                e.Cancel = true;
                textBoxId.BackColor = Color.Red;
            }
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            textBoxId.BackColor = Color.LightBlue;
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
