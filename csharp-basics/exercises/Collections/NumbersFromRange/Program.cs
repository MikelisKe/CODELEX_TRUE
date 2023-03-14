using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var random = new Random();
            var numbers = new List<int>();
            
            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }

            var result = numbers.
                TakeWhile(i => i< 100).
                Where(i => i>30);

            Console.WriteLine(String.Join(",", numbers));
            Console.WriteLine(String.Join(",", result));
            Console.ReadKey();
        }
    }
}
