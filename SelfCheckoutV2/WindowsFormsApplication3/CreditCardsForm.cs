using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreditCardsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDBDataSet.Mokejimo_kortele' table. You can move, or remove it, as needed.
            GetData();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCreditCardForm accf = new AddCreditCardForm(f1, f2, f3);
            accf.ShowDialog();
        }
        public void GetData()
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aurimas\Documents\GitHub\SelfCheckout\SelfCheckoutV2\WindowsFormsApplication3\ShopDB.mdf;Integrated Security=True"))
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Mokejimo_kortele", cn);
                DataTable dt = new DataTable();
                dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                da.Fill(dt);
                mokejimokorteleBindingSource.DataSource = dt;
                da.Dispose();
                //gridProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            }
        }

        private void gridCards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCards.Columns[e.ColumnIndex].Name == "remove")
            {
                f1.cm.removeCreditCardFromDatabase(gridCards.Rows[e.RowIndex].Cells[0].Value.ToString());
                GetData();
                //df.Show();
                //this.ResetBindings(true);
                //f2.ResetBindings(true);
            }
        }
    }
}
