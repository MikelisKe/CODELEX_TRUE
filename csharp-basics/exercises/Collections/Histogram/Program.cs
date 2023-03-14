using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Histogram
{
    class Program
    {
        public const string Path = @"C:\\Users\\Mikelis\\Desktop\\00_Darba maiņa\\Codelex\\CODELEX_LOCAL\\csharp-basics\\exercises\\Collections\\Histogram\\midtermscores.txt";

        public static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);
            var texList = readText.Split(' ').ToList();

            
            Console.WriteLine("00-09:" + new string('*', texList.Count(f => int.Parse(f) >= 0 && int.Parse(f) < 10)));
            Console.WriteLine("10-19:" + new string('*', texList.Count(f => int.Parse(f) > 9 && int.Parse(f) < 20)));
            Console.WriteLine("20-29:" + new string('*', texList.Count(f => int.Parse(f) > 19 && int.Parse(f) < 30)));
            Console.WriteLine("30-39:" + new string('*', texList.Count(f => int.Parse(f) > 29 && int.Parse(f) < 40)));
            Console.WriteLine("40-49:" + new string('*', texList.Count(f => int.Parse(f) > 39 && int.Parse(f) < 50)));
            Console.WriteLine("50-59:" + new string('*', texList.Count(f => int.Parse(f) > 49 && int.Parse(f) < 60)));
            Console.WriteLine("60-69:" + new string('*', texList.Count(f => int.Parse(f) > 59 && int.Parse(f) < 70)));
            Console.WriteLine("70-79:" + new string('*', texList.Count(f => int.Parse(f) > 69 && int.Parse(f) < 80)));
            Console.WriteLine("80-89:" + new string('*', texList.Count(f => int.Parse(f) > 79 && int.Parse(f) < 90)));
            Console.WriteLine("90-100:" + new string('*', texList.Count(f => int.Parse(f) > 89 && int.Parse(f) <= 100)));
            
            Console.ReadKey();
        }
    }
}
