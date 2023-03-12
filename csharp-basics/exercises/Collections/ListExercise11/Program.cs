using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("a");
            list.Add("c");
            list.Add("b");
            list.Add("n");
            list.Add("r");
            list.Add("y");
            list.Add("u");
            list.Add("p");
            list.Add("Foobar");
            list.Add("q");

            Console.WriteLine("list of 10 elements:");
            Console.WriteLine(string.Join(",", list));

            list.Insert(4, "l");
            Console.WriteLine("Inserted nev value in 5th position:");
            Console.WriteLine(string.Join(",", list));

            var a = list.Count -1;
            list[a] = "k";

            Console.WriteLine("Changed the value of last position:");
            Console.WriteLine(string.Join(",", list));


            list.Sort();
            Console.WriteLine("Alphabetical order ");
            Console.WriteLine(string.Join(",", list));



            var foo = list.Contains("Foobar") ? true :false;
            Console.WriteLine($"Does list contains foobar?, its {foo}");


            Console.WriteLine("printing out using for loop:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }

            Console.ReadKey();
        }
    }
}
