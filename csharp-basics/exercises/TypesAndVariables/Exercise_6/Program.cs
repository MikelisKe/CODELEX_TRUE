internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number1: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a number2: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a number3: ");
        double num3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a number4: ");
        double num4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("sum: " + (num1 + num2 + num3 + num4));

        Console.ReadKey();

    }
}