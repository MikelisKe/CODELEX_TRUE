using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            Console.WriteLine("Cars array to List");
            List<string> cars = array.ToList();

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("Cars in Hashset");
            HashSet<string> carSet = new HashSet<string>(cars);

            foreach (var car in carSet)
            {
                Console.WriteLine(car);
            }
            
            Dictionary<string,string> org = new Dictionary<string, string>()
            {
                { "Audi", "Germany" },
                { "BMW", "Germany" },
                { "Honda", "Japan" },
                { "Mercedes", "Germany" },
                { "VolksWagen", "Germany" },
                { "Tesla", "USA" }
            };

            Console.WriteLine("organizaations:");
            foreach (var item in org)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
