internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Choose some normal number:");
        CheckOddEven();
        Console.WriteLine("Bye");

        static void CheckOddEven()
        {
            int num = Convert.ToInt32( Console.ReadLine());
            if (num % 2 == 0 )
            {
                Console.WriteLine($"This number: {num} is even");
            }
            else
            {
                Console.WriteLine($"This number: {num} is odd");
            }
        }

    }
}