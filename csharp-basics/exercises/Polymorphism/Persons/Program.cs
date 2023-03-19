using System;
using System.Collections.Generic;

namespace Persons
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Animal> A = new List<Animal>();
            var input = string.Empty;
            while (input != "End")
            {
                Console.WriteLine("Input the type of animal you want to choose: ");
                input = Console.ReadLine();
                var arguments = input.Split(',');
                switch (arguments[0])
                {
                    case "Cat":
                        var cat = new Cat(arguments[1], double.Parse(arguments[2]), 0, arguments[3], arguments[4]);
                        A.Add(cat);
                        cat.MakeSound();
                        Console.WriteLine("feed me with ?");
                        var inpu = Console.ReadLine();
                        var arg = inpu.Split(',');
                        var food = new Food(int.Parse(arg[1]));
                        cat.Eat(food,int.Parse(arg[1]));
                        Console.WriteLine(cat.ToString());
                        break;

                    case "Zebra":
                        var zebra = new Zebra(arguments[1], double.Parse(arguments[2]),0, arguments[3]);
                        A.Add(zebra);
                        zebra.MakeSound();
                        Console.WriteLine("feed me with ?");
                        var zinpu = Console.ReadLine();
                        var zarg = zinpu.Split(',');
                        var zfood = new Food(int.Parse(zarg[1]));
                        zebra.Eat(zfood, int.Parse(zarg[1]));
                        Console.WriteLine(zebra.ToString());
                        break;

                    case "Tiger":
                        var tiger = new Tiger(arguments[1], double.Parse(arguments[2]), 0, arguments[3],
                            arguments[4]);
                        A.Add(tiger);
                        tiger.MakeSound();
                        Console.WriteLine("feed me with ?");
                        var tInput = Console.ReadLine();
                        var targ = tInput.Split(',');
                        var tFood = new Food(int.Parse(targ[1]));
                        tiger.Eat(tFood, int.Parse(targ[1]));
                        Console.WriteLine(tiger.ToString());
                        break;

                    default:
                        input = "End";
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}