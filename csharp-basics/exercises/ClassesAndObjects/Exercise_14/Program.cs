using Exercise_14;

internal class Program
{
    public static void Main(string[] args)
    {
        Date dayDate1 = new Date(2020, 4, 21);

        Console.WriteLine(dayDate1.Day());
        Console.ReadKey();
    }
}
