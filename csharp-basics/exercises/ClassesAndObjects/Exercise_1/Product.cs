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
        List<Product> _products;

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
            string input = Console.ReadLine();
            int intParse = int.Parse(input);
            return _ammount += intParse;
        }
        public double ChangePrice()
        {
            Console.WriteLine("Whats the new price?");
            string input = Console.ReadLine();
            double intParse = double.Parse(input);
            return _price += intParse;
        }
    }
}

