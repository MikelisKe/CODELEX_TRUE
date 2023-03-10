// See https://aka.ms/new-console-template for more information

using Exercise_3;

internal class Program
{
    public static void Main(string[] args)
    {
        var fuelGauge = new FuelGauge(0);
        var Odometer = new Odometer(0, fuelGauge);

        Console.WriteLine("Fuel up tank");
        var tank = int.Parse( Console.ReadLine());
        for (int i = 0; i < tank; i++)
        {
            fuelGauge.incrementFuel();
        }

        Console.WriteLine("Whats the km to drive?");
        var km = int.Parse( Console.ReadLine());
        for (int i = 0; i < km; i++)
        {
            Odometer.Drive();
        }

        Console.WriteLine($" odo report {Odometer.Report()} and fuel report {fuelGauge.FuelReport()} ");
        Console.ReadKey();

    }
}
