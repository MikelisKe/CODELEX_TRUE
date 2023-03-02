internal class NumberSquare
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Min?");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Max?");
        int max = int.Parse(Console.ReadLine());

        for (int i = min; i <= max; i++)
        {
            for (int iter = i; iter <= max; iter++)
            {
                Console.Write(iter);
            }
            for (int a = min; a < i; a++)
            {
                Console.Write(a);
            }

            Console.WriteLine();        
        }
    }
}