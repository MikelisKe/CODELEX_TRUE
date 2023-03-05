using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise_1
{
    class Product
    {
        public double Price;
        public int ammount;
        private string name;

        public Product(string aName, double aPrice, int aAmmount)
        {
            name = aName;
            Price = aPrice;
            ammount = aAmmount;
        }

        public string PrintProduct()
        {
            string b = name + ", Price " + Price.ToString() + ", ammount "+ammount.ToString();
            return b;
        }

        public int ChangeQuantitity()
        {
            Console.WriteLine("Whats the new ammount of product, you want to add");
            int q = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            return ammount + q;
        }
        public double ChangePrice()
        {
            Console.WriteLine("Whats the new price?");
            double p = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            return p;
        }
    }
}

