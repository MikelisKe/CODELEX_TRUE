// See https://aka.ms/new-console-template for more information

using Exercise_3;

internal class Program
{
    public static void Main(string[] args)
    {
        var fueGauge = new FuelGauge();
        var Odometer = new Odometer(fueGauge);
        Console.WriteLine("Put the gas");

        for (int i = 0; i < 70; i++)
        {
            fueGauge.incrementFuel();
        }

        Console.WriteLine($" gas");
        for (int i = 0; i < 100; i++)
        {
            
        }
        Console.ReadKey();

    }
}
