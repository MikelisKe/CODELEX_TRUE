using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> colors = new List<string>();

            colors.Add("Green");
            colors.Add("black");
            colors.Add("smuka krāsa");
            colors.Add("blue");
            colors.Add("red");

            foreach (var col in colors)
            {
                Console.WriteLine(col);
            }

            Console.ReadKey();
        }
    }
}
