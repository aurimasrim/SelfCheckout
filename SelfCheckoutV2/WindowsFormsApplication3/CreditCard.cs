using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class CreditCard
    {
        public string Number { get; }
        private string password;
        private double balance;
        public double Balance
        {
            get { return balance; }
        }
        public CreditCard(string number, string password, double balance)
        {
            this.Number = number;
            this.password = password;
            this.balance = balance;
        }

        public bool passwordEquals(string password)
        {
            if (this.password == password) return true;
            else return false;
        }
        public bool chargeBalance(double price)
        {
            if (balance >= price)
            {
                balance -= price;
                return true;
            }
            else return false;
        }
    }
}
