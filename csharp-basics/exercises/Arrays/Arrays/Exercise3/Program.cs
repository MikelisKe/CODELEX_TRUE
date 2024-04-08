using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            // int[] numbers = {20, 30, 25, 35, -16, 60, -100};
            int sum = 0;
            var rnd = new Random(10);

            List<int> numbers = new List<int>();
            int randomeTimes = rnd.Next(1,10);
            Console.WriteLine($"Enter {randomeTimes} random numbers to measure their average number: ");

            for (int i = 0; i < randomeTimes; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            };

            for (int i = 0 ; i< numbers.Count; i++)
            {
                sum += numbers[i];
            }

            int average = sum / (numbers.Count);                     
            Console.WriteLine("Average value of the array elements is : " + average);
            Console.ReadKey();            
        }
    }
}
