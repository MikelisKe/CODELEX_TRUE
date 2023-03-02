using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = int.Parse(Console.ReadLine());

            int result = 0;
        
            if (input1 > input2 && input1 > input3)
            {
                result = input1;
            }
            else if (input2 > input1 && input2 > input3)
            {
                result = input2;
            }
            else
            {
                result = input3;
            }

            Console.WriteLine($"The largest number is {result}");
            Console.ReadKey();
        }
    }
}
