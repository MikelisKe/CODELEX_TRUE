using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        int distanceMeters = 2500;
        double distanceKm = (double)distanceMeters / 1000.00;
        double distanceMiles = (distanceMeters / 1609.00);
        int hour = 5;
        int minutes = 56;
        int seconds = 23;
        double decMinutes = (seconds/ 60.00)+ minutes;
        double hoursAll = (decMinutes/60)+hour;
        double metersHour = distanceMeters / hoursAll;
        double kmHour = metersHour / 1000;
        int secondsAll = (hour * 60 * 60) + (minutes * 60) + seconds;
        double mS = (double)distanceMeters / secondsAll;
        double mph = (double)distanceMiles / hoursAll;

        Console.WriteLine($"There was a track with this many kilometers:{distanceKm} ");
        Console.WriteLine($"Turtle came down running it in {hoursAll} hours");
        Console.WriteLine($"Actually it was precisely {Math.Round(kmHour, 8)} kilometers per hour");
        Console.WriteLine($"And every {secondsAll} second he thought it will be some kind of a record");
        Console.WriteLine($"But after som while when he was going {Math.Round(mS,8)} meters per second");
        Console.WriteLine($"And some of the {Math.Round(distanceMiles, 2)} miles distance");
        Console.WriteLine($"He realized that in USA it is {Math.Round(mph,8)} miles per hour and there was some tutoise who swam faster");
        Console.WriteLine("The end!");

    }
}