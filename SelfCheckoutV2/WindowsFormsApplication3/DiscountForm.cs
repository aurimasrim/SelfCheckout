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
    partial class DiscountForm : Form
    {
        CheckoutForm f1;
        ClientForm f2;
        AdminForm af;
        int RowIndex;
        public DiscountForm(CheckoutForm f1, ClientForm f2, AdminForm af, int rowIndex)
        {
            InitializeComponent();
            this.f1 = f1;
            this.f2 = f2;
            this.af = af;
            this.RowIndex = rowIndex;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            f1.cm.Productsdatabase.Replace(af.gridProducts.CurrentCell.RowIndex, (Product)f1.cm.Productsdatabase[af.gridProducts.CurrentCell.RowIndex].CloneWithDiscount(int.Parse(textBoxDiscount.Text)));
            af.ResetBindings(true);
            f2.ResetBindings(true);
            this.Close();
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

        private void textBoxDiscount_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            this.Close();
        }
    }
}
