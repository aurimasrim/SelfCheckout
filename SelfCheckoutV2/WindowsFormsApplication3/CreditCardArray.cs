using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class CreditCardArray : CustomArray <CreditCard>
    {
        public CreditCardArray (string path)
        {
            ReadFromFile(path);
        }
        private void ReadFromFile(string path)
        {
            string line = null;
            StreamReader reader = new StreamReader(path, Encoding.Default);
            while ((line = reader.ReadLine()) != null)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(line, @"^\d{5,}/\d{4}/\d+(,\d)?\d?$"))
                {
                    char splitter = '/';
                    string[] splittedLine = line.Split(splitter);
                    CreditCard card = new CreditCard(splittedLine[0], splittedLine[1], double.Parse(splittedLine[2]));
                    if (!this.Contains(card))
                    {
                        this.Add(card);
                    }
                }
                else throw new IOException();
            }
            reader.Close();
        }
    }
}
