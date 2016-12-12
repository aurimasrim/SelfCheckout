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
        public string Type { get; }
        public string BankName { get; }
        public string PasswordHash { get; }
        public string PasswordSalt { get; }
        public double balance;
        
        public double Balance
        {
            get { return balance; }
        }
        public CreditCard(string number, string type, string bankName, string passwordHash, string passwordSalt, double balance)
        {
            this.Number = number;
            this.Type = type;
            this.BankName = bankName;
            this.PasswordHash = passwordHash;
            this.PasswordSalt = passwordSalt;
            this.balance = balance;
        }

        public bool passwordEquals(string passwordHash)
        {
            if (this.PasswordHash == passwordHash) return true;
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
