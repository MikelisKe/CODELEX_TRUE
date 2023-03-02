using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");
            var input = long.Parse(Console.ReadLine());
            long bil = 10000000000;
            int digits = 1;

            if (input < bil)
            {
                if (input < 0)
                {
                    input *= -1;
                }
                else if (input >= bil)
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                }
                else
                {
                    if (input / 10 < 10)
                    {
                        digits = 2;
                    }
                    else if (input / 100 < 10)
                    {
                        digits = 3;
                    }
                    else if (input / 1000 < 10)
                    {
                        digits = 4;
                        input /= 10;
                        Console.WriteLine(input);
                    }
                    else if (input / 10000 < 10)
                    {
                        digits = 5;
                    }
                    else if (input / 100000 < 10)
                    {
                        digits = 6;
                    }
                    else if (input / 1000000 < 10)
                    {
                        digits = 7;
                    }
                    else if (input / 10000000 < 10)
                    {
                        digits = 8;
                    }
                    else if (input / 100000000 < 10)
                    {
                        digits = 9;
                    }
                    else if (input / 1000000000 < 10)
                    {
                        digits = 10;
                    }
                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            }
            else
            {
                Console.WriteLine("The number is not a long");
            }

            Console.ReadKey();
        }
    }
}
