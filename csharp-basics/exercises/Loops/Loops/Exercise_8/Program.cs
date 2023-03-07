internal class AsciiFigure
{
    private static void Main(string[] args)
    {
        Console.Write("Insert the n:");
        Console.WriteLine();
        int n = int.Parse(Console.ReadLine());
        int back = 4*(n-1);
        int slash = 4*(n- 1);
        int star = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('/', back));
            Console.Write(new string('*', star));
            Console.Write(new string('\\', slash));
            Console.WriteLine();

            back = back-4;
            slash = slash-4;            
            star = star  + 8;
        }

        Console.ReadKey();
    }
}
