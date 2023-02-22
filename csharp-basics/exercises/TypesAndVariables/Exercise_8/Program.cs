internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter minutes");
        int minutes = int.Parse(Console.ReadLine());
        double minToYears = Convert.ToDouble(minutes / (365 * 24 * 60));
        double minToDays = minutes / (24 * 60);

        Console.WriteLine($" {minutes} minutes are {minToYears} years and {minToDays} days");
        Console.ReadKey();
    }
}