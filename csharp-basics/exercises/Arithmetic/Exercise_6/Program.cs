internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insert the number co create CozaLozaWoza");
        int max = Convert.ToInt32(Console.ReadLine());
        CozaLozaWoza(max);
        static void CozaLozaWoza(int max)
        {
            for (var i = 1; i < max; i++)
            {
                if (i % 11 == 0)
                {
                    Console.WriteLine();
                }
                else if (i % 105 == 0)
                {
                    Console.Write("CozaLozaWoza ");
                }
                else if (i % 15 == 0)
                {
                    Console.Write("CozaLoza ");
                }
                else if (i % 21 == 0)
                {
                    Console.Write("CozaWoza ");
                }
                else if (i % 35 == 0)
                {
                    Console.Write("WozaLoza ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Coza ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Loza ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}