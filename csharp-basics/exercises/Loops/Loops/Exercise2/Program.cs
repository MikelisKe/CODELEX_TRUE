using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (i = 0; i < n; i++)
            {
                sum = (i+1) * (i+1);
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
