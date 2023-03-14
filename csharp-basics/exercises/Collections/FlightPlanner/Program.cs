using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        public const string Path = @"C:\Users\Mikelis\Desktop\00_Darba maiņa\Codelex\CODELEX_LOCAL\csharp-basics\exercises\Collections\FlightPlanner\flights.txt";


        public static void Main(string[] args)
        {
            var readText = System.IO.File.ReadAllLines(Path).ToList();

            Console.WriteLine("Lets start! where are you : ");
            var start = Console.ReadLine();
            var end = "";
            var firstOpt = "";
            foreach (var v in readText)
            {
                if (v != "")
                {
                    var index = v.IndexOf('-');
                    var part1 = v.Substring(0, index - 1);
                    var part2 = v.Substring(index + 2);

                    if (part1 == start)
                    {
                        firstOpt += $" {part2}";
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine(firstOpt);

            while (start != end)
            {
                Console.WriteLine("You can fly to:");
                end = Console.ReadLine();
                Console.WriteLine(Destination(end));
            }

            Console.WriteLine($"Thank you for using this airLines! You`re again in {start} ");
            Console.ReadKey();

            string Destination(string End)
            {
                var options = "";
                foreach (var v in readText)
                {
                    if (v != "")
                    {
                        var index = v.IndexOf('-');
                        var part1 = v.Substring(0, index-1);
                        var part2 = v.Substring(index + 2);

                        if (part1 == end)
                        {
                            options += $" {part2}";
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                return options;
            }
        }
    }
}
