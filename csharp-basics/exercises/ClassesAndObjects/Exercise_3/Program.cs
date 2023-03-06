// See https://aka.ms/new-console-template for more information

using Exercise_3;

internal class Program
{
    public static void Main(string[] args)
    {
        FuelGauge carProgram = new FuelGauge(70,0);
        Odometer odo = new Odometer(0);

        Console.WriteLine("Input fuel to star the drive: ");
        var input = Int32.Parse(Console.ReadLine());
        carProgram.incrementFuel(input);

        carProgram.Drive(carProgram.fuel,odo.currentOdeometer);
      

        Console.ReadKey();

    }
}
