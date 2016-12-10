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
    partial class HelpForm : Form
    {
        CheckoutForm checkoutForm;
        ClientForm clientForm;
        AdminForm adminForm;
        public HelpForm(CheckoutForm checkoutForm, ClientForm clientForm, AdminForm adminForm)
        {
            InitializeComponent();
            this.checkoutForm = checkoutForm;
            this.clientForm = clientForm;
            this.adminForm = adminForm;
        }
        private void HelpForm_Load(object sender, EventArgs e)
        {
            buttonAdminWindow.Tag = adminForm;
            buttonClientWindow.Tag = clientForm;
            buttonCheckoutWindow.Tag = checkoutForm;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            buttonHelp_Click(sender, e) ;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            if (this.Height == 51)
            {
                this.Width = 700;
                this.Height = 265;
            }
            else
            {
                this.Width = 640;
                this.Height = 51;
            }
        }

        private void buttonWindow_Click(object sender, EventArgs e)
        {
            var temp = ((Button)sender).Tag;
            if (((Form)temp).Visible)
                ((Form)temp).Hide();
            else ((Form)temp).Show();
        }
    }
}
