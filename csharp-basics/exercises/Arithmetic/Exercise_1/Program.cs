internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input two integers to solve the mistery:");
        int devider = int.Parse(Console.ReadLine());
        if (devider == 15)
        {
            Console.WriteLine("The number you wrote is 15");
        }
        else if (devider % 15 == 0)
        {
            Console.WriteLine("The number you wrote is divisible by 15");
        }
        else
        {
            Console.WriteLine("The number is shit");
        }
        Console.ReadKey();
    }
}