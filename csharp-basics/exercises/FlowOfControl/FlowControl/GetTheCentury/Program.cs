using System;
using System.Runtime.Intrinsics.X86;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the year to find out the sentury between 1000 to 2010:");
            int year = int.Parse(Console.ReadLine());
            int sentury = 0;

            if (year < 1000 || year > 2010)
            {
                Console.WriteLine("Try to read the regulations again! ");
            }
            else
            {
                if (year % 100 != 0)
                {
                    sentury = (year / 100) + 1;
                }
                else
                {
                    sentury = year / 100;
                }
            }

            Console.WriteLine($"{year} is the {sentury}`th sentury");
        }
        
    }
}
