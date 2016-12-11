﻿using System;
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
    partial class CreditCardsForm : Form
    {
        CheckoutForm f1;
        ClientForm f2;
        AdminForm f3;
        public CreditCardsForm(CheckoutForm f1, ClientForm f2, AdminForm f3)
        {
            this.f1 = f1;
            this.f2 = f2;
            this.f3 = f3;
            InitializeComponent();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Monitor.Enter(f1.cm.Productsdatabase);
                try
                {
                    f1.cm.readFromInternet(textBoxAddress.Text);
                    f3.GetData();
                    //f2.ResetBindings(true);
                    //f3.ResetBindings(true);
                }
                catch (System.Net.WebException)
                {
                    MessageBoxForm.Show("Blogas adreso formatas");
                }
                
                catch (Exception)
                {
                    MessageBoxForm.Show("Blogas adreso formatas");
                }
                finally
                {
                    Monitor.Exit(f1.cm.Productsdatabase);
                    this.Invoke((MethodInvoker)delegate () {this.Close(); }); ;
                }


                //thread.Join();

            });
            thread.Start();
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreditCardsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDBDataSet.Mokejimo_kortele' table. You can move, or remove it, as needed.
            this.mokejimo_korteleTableAdapter.Fill(this.shopDBDataSet.Mokejimo_kortele);

        }
    }
}