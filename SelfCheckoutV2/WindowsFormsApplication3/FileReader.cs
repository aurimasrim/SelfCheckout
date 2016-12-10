using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication3
{
    class FileReader : DataReader
    {
        public void ReadData<T>(CustomArray<T> dataArray, string path)
        {
            StreamReader dataReader = new StreamReader(path, Encoding.Default);
            string line;

            while ((line = dataReader.ReadLine()) != null)
            {
                char splitter = '/';
                string[] splittedLine = line.Split(splitter);
                if (System.Text.RegularExpressions.Regex.IsMatch(line, @"^.+/\d{8}(\d{5})?/\d+/\d+(,\d)?\d?(/\d+)?$"))
                {
                    Product product;
                    if (splittedLine.Length == 5)
                        product = new Product(splittedLine[0], splittedLine[1], int.Parse(splittedLine[2]), double.Parse(splittedLine[3]), (Attributes)int.Parse(splittedLine[4]));
                    // Jei nenurodomas Attributes
                    else
                        product = new Product(splittedLine[0], splittedLine[1], int.Parse(splittedLine[2]), double.Parse(splittedLine[3]));
                    if (!dataArray.Contains((T)(object)product))
                    {
                        dataArray.Add((T)(object)product);
                    }
                }
                else throw new IOException();
            }
            dataReader.Close();
        }
    }
}
