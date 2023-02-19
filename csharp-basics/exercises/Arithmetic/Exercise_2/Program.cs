internal class Program
{
    private static void Main(string[] args)
    {
        CheckOddEven();

        static void CheckOddEven()
        {
            for (var i = 1 ; i < 10; i++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine("bye");
                }
            }
        }

    }
}