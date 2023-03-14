using System;
using System.Collections.Generic;
using System.Linq;



namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };

            var result = values.Distinct().ToList();

            Console.WriteLine(String.Join(",", result));
            Console.ReadKey();
        }
    }
}
