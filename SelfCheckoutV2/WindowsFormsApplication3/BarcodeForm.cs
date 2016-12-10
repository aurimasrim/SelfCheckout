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
    partial class BarcodeForm : Form
    {
        CheckoutForm f1;
        public BarcodeForm(CheckoutForm f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //f1.scan(textBoxBarcode.Text);
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

        private void textBoxBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch_Click(sender, e);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
