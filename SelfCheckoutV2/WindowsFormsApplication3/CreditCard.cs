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
        private string type;
        private string bankName;
        private string passwordHash;
        private string passwordSalt;
        private double balance;
        
        public double Balance
        {
            get { return balance; }
        }
        public CreditCard(string number, string type, string bankName, string passwordHash, string passwordSalt, double balance)
        {
            this.Number = number;
            this.type = type;
            this.bankName = bankName;
            this.passwordHash = passwordHash;
            this.passwordSalt = passwordSalt;
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
