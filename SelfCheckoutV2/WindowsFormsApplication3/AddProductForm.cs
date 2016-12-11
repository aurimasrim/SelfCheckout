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
    partial class AddProductForm : Form
    {
        CheckoutForm f1;
        ClientForm f2;
        AdminForm f3;
        string Barcode;
        Attributes attributes = Attributes.None;
        public AddProductForm(CheckoutForm f1, ClientForm f2, AdminForm f3)
        {
            this.f1 = f1;
            this.f2 = f2;
            this.f3 = f3;
            InitializeComponent();
        }
        public AddProductForm(CheckoutForm f1, ClientForm f2, AdminForm f3, string barcode)
        {
            this.f1 = f1;
            this.f2 = f2;
            this.f3 = f3;
            Barcode = barcode;
            InitializeComponent();

            textBoxBarcode.ReadOnly = true;
            textBoxBarcode.BackColor = Color.DarkViolet;
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            textBoxBarcode.Text = Barcode;
            
            checkBoxPaidTare.Tag = Attributes.PaidTare;
            checkBoxAlcohol.Tag = Attributes.Alcohol;

            checkBoxPaidTare.CheckedChanged += enumCheckedChanged;
            checkBoxAlcohol.CheckedChanged += enumCheckedChanged;

            comboCategories.DataSource = Enum.GetNames(typeof(Category));
            comboCategories.SelectedIndex = 0;
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
            f1.cm.addProductToDatabase(new Product(textBoxName.Text, textBoxBarcode.Text, int.Parse(textBoxWeight.Text), float.Parse(textBoxPrice.Text), (Category)comboCategories.SelectedIndex, attributes));

            f3.GetData();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxBarcode_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxBarcode.Text, @"^\d{8}$|^\d{13}$"))
            {
                e.Cancel = true;
                textBoxBarcode.BackColor = Color.Red;
            }
        }
        private void textBoxBarcode_Validated(object sender, EventArgs e)
        {
            textBoxBarcode.BackColor = Color.LightBlue;
        }

        private void textBoxWeight_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxWeight.Text, @"^\d+$"))
            {
                e.Cancel = true;
                textBoxWeight.BackColor = Color.Red;
            }
        }

        private void textBoxWeight_Validated(object sender, EventArgs e)
        {
            textBoxWeight.BackColor = Color.LightBlue;
        }

        private void textBoxPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxPrice.Text, @"^\d+(,\d)?\d?$"))
            {
                e.Cancel = true;
                textBoxPrice.BackColor = Color.Red;
            }
        }

        private void textBoxPrice_Validated(object sender, EventArgs e)
        {
            textBoxPrice.BackColor = Color.LightBlue;
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxName.Text, @"^.+$"))
            {
                e.Cancel = true;
                textBoxName.BackColor = Color.Red;
            }
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            textBoxName.BackColor = Color.LightBlue;
        }
    }
}
