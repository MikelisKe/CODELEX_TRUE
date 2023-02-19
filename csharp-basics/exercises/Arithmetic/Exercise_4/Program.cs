internal class Program
{
    private static void Main(string[] args)
    {
        int num = 10;
        int factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("The factorial of {0} is {1}", num, factorial);

    }
}