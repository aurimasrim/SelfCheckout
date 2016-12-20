using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public enum Category
    {
        Kita = 0,
        AlkoholiniaiGerimai = 1,
        NealkoholiniaiGerimai = 2,
        Vaisiai = 3,
        Darzoves = 4,
        PienoProduktai = 5,
        DuonosGaminiai = 6,
    }
    [Flags]
    public enum Attributes
    {
        None = 0,
        NeedsApproval = 1,
        PaidTare = 2,
        HaveCardDiscount = 4
    };
    struct Product : IComparable, IEquatable<Product>, ICloneable
    {
        public static Product Tare
        {
            get { return new Product("Butelio tara", "00000001", 0, (double)0.1, Category.Kita); }
        }
        public static Product Bag
        {
            get { return new Product("Maišelis", "00000000", 10, (double)0.15, Category.Kita); }
        }
        public string Pname { get; }
        public double Price { get; set; }
        public int Weight { get; }
        public string Barcode { get; }
        public Category Pcategory { get; set; }
        public Attributes Pattributes { get; set; }
        public Product(string name, string barcode, int weight, double price, Category category, Attributes attributes = Attributes.None)
        {
            this.Pname = name;
            this.Barcode = barcode;
            this.Pattributes = attributes;
            this.Weight = weight;
            this.Price = price;
            this.Pcategory = category;
            
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
            return new Product(Pname, Barcode, Weight, Price, Pcategory, Pattributes);
        }
        public object CloneWithDiscount(int discountPercentage)
        {
            return new Product(Pname, Barcode, Weight, Math.Round(Price - (Price * discountPercentage / 100), 2), Pcategory, Pattributes | Attributes.HaveCardDiscount);
        }
        public void AddAttribute(Attributes at)
        {
            Pattributes = Pattributes | at;
        }
    }
}
