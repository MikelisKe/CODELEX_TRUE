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
        private double _price;
        private int _ammount;
        private string _name;
        private ConsoleKeyInfo _key = Console.ReadKey(true);

        public Product(string aName, double aPrice, int aAmmount)
        {
            _name = aName;
            _price = aPrice;
            _ammount = aAmmount;
        }

        public override string ToString()
        {
            string b = _name + ", Price " + _price + ", ammount " + _ammount;
            return b;
        }

        public int ChangeQuantitity()
        {
            Console.WriteLine("Whats the ammount of product, you want to add");
            int q = int.Parse(_key.KeyChar.ToString() ?? throw new InvalidOperationException());
            return _ammount += q;
        }
        public double ChangePrice()
        {
            Console.WriteLine("Whats the new price?");
            double p = double.Parse(_key.KeyChar.ToString() ?? throw new InvalidOperationException());
            return _price = p;
        }
    }
}

