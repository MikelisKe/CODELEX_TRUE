using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, eyes, teeth, hair;
            int age, height, weight;

            name = "Zed A. Shaw";
            age = 35;
            height = 74;  // inches
            weight = 180; // lbs
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + Math.Round(height * 2.54, 2) + " inches tall.");
            Console.WriteLine("He's " + Math.Round(weight * 0.453592, 2) + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight
                               + " I get " + (age + height + weight) + ".");

            Console.ReadKey();
        }
    }
}