internal class Program
{
    static int factorial = 1;
    private static void Main(string[] args)
    {
        const int num = 10;
        

        Product1ToN();

        static void Product1ToN()
        {
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of {0} is {1}", num, factorial);
        }
    }
}