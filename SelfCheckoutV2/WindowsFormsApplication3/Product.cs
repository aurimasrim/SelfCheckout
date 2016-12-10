using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    [Flags]
    public enum Attributes
    {
        None = 0,
        Drink = 1,
        PaidTare = 2,
        Alcohol = 4,
        Fruit = 8,
        Vegetable = 16,
        Dairy = 32,
        HaveDiscount = 64
    };
    struct Product : IComparable, IEquatable<Product>, ICloneable
    {
        public static Product Tare
        {
            get { return new Product("Butelio tara", null, 0, (double)0.1); }
        }
        public static Product Bag
        {
            get { return new Product("Maišelis", null, 10, (double)0.15); }
        }
        public string Pname { get; }
        public double Price { get; }
        public int Weight { get; }
        public string Barcode { get; }
        public Attributes Pattributes { get; set; }
        public Product(string name, string barcode, int weight, double price, Attributes attributes = Attributes.None)
        {
            this.Pname = name;
            this.Barcode = barcode;
            this.Pattributes = attributes;
            this.Weight = weight;
            this.Price = price;
        }
        public int CompareTo(Object obj)
        {
            Product temp = (Product)obj;
            return this.Pname.CompareTo(temp.Pname);
        }
        public override string ToString()
        {
            return Pname + " " + Barcode + " " + Weight + " " + Price + " " + Pattributes.ToString();
        }

        public bool Equals(Product other)
        {
            return this.Barcode == other.Barcode;
        }
        public object Clone()
        {
            return new Product(Pname, Barcode, Weight, Price, Pattributes);
        }
        public object CloneWithDiscount(int discountPercentage)
        {
            if (!Pattributes.HasFlag(Attributes.HaveDiscount))
            {
                return new Product(Pname, Barcode, Weight, Math.Round(Price - (Price * discountPercentage / 100), 2), Pattributes | Attributes.HaveDiscount);
            }
            else return this;
        }
        public void AddAttribute(Attributes at)
        {
            Pattributes = Pattributes | at;
        }
    }
}
