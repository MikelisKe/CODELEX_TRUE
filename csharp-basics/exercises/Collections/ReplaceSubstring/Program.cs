using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            var result = words.Select(i => i.Replace("ea", "*"));

            Console.WriteLine(String.Join(",", result));
            Console.ReadKey();
        }
    }
}
