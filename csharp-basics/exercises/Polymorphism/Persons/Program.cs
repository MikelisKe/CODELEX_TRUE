using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = 5;
            var fakt = 1;
            for (var i = 2; i < n+1; i++)
            {
                var num = i;
                fakt = fakt * num;
            }

            Console.WriteLine(fakt);
            Console.ReadKey();
        }
    }
}