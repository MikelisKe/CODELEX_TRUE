using System.Security.Cryptography;
using System.Threading.Channels;
using System.Xml.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the numbers to check it is happy:");
        int test = int.Parse(Console.ReadLine());
        int input = test;


        while (input != 1 && input != 4)
        {
            int sum = 0;
            while (input != 0)
            {
                int digit = input % 10;
                sum += digit * digit;
                input /= 10;
            }
            input = sum;
        }

        if (input == 1)
        {
            Console.WriteLine($"the number {test} is Happy");
        }
        else
        {
            Console.WriteLine($"Sad number {test} ends with {input}");
        }

    }
}

