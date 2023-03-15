using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Lexus());
            cars.Add(new Moscvich400());
            cars.Add(new Opel());
            cars.Add(new Tesla());

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    cars.ForEach(c=> c.StartEngine());
                }
                else
                {
                    for (int j = 0; j < cars.Count; j++)
                    {
                        if (i == 2)
                        {
                            if (cars[j] is IBoost boost)
                            {
                                boost.UseNitrousOxideEngine();
                            }
                            else
                            {
                                cars[j].SpeedUp();
                            }
                        }
                        else
                        {
                            cars[j].SpeedUp();
                        }
                    }
                }
            }

            var max = cars.Max(c => int.Parse(c.ShowCurrentSpeed()));
            var first = cars.First(c => c.ShowCurrentSpeed() == max.ToString());

            Console.WriteLine($"{first.GetType()} : {max}");

            Console.ReadKey();
        }
    }
}