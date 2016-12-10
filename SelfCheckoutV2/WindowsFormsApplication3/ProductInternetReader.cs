using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication3
{
    class InternetReader : DataReader
    {
        public void ReadData<T>(CustomArray <T> dataArray, string path)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            wc.Encoding = Encoding.UTF8;
            string webdata = wc.DownloadString(path);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(webdata);

            foreach (HtmlAgilityPack.HtmlNode node in doc.DocumentNode.SelectNodes("//ul[@id='productList']//li"))
            {
                HtmlAgilityPack.HtmlNode node1 = node.SelectSingleNode(".//a[@class='titleBlock title fn']");
                string name = node1.Attributes["title"].Value;
                name = name.Replace("&#039;", "'");
                name = name.Replace("&quot;", "\"");
                node1 = node.SelectSingleNode(".//div//strong");
                string content = node1.InnerText;
                string price = Regex.Match(content, @"\d+,\d\d").ToString();
                node1 = node.SelectSingleNode(".//script");
                content = node1.InnerText;
                Match match = Regex.Match(content, @"\d(\.\d)?\d?");
                string weight = match.Value;

                double weightf = double.Parse(weight, System.Globalization.CultureInfo.InvariantCulture);
                weightf = weightf * 1000;
                int weighti = (int)weightf;
                double pricef = double.Parse(price);
                pricef = Math.Round(pricef, 2);

                Random rnd = new Random();
                int barcode;
                //MessageBox.Show(barcode.ToString());
                for (;;)
                {

                    barcode = rnd.Next(10000000, 99999999);
                    Product pr = new Product(null, barcode.ToString(), 0, 0);
                    if (!dataArray.Contains((T)(object)pr))
                        break;

                }
                Product product = new Product(name, barcode.ToString(), weighti, pricef);
                dataArray.Add((T)(object)product);
            }

        }
    }
}
