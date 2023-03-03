using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Product
    {
        public double price;
        public double ammount;
        private string name;

        public Product(string aname, double priceAtStart, int amountAtStart)
        {
            name = aname;
            price = priceAtStart; 
            ammount = amountAtStart;
            Console.WriteLine($"{name}, priece {price}, amount {ammount}");
        }
    }
}
