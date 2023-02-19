using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            double average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
            }

            average = (sum / Convert.ToDouble( upperBound));
            Console.WriteLine(sum);
            Console.WriteLine(average);
            Console.ReadKey();
        }
    }
}
