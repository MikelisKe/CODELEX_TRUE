using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = @"C:\Users\Mikelis\Desktop\00_Darba maiņa\Codelex\CODELEX_LOCAL\csharp-basics\exercises\Collections\FlightPlanner\flights.txt";
        

        private static void Main(string[] args)
        {
            var readText = System.IO.File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(readText);
            Console.ReadKey();
        }
    }
}
