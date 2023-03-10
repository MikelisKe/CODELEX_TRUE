using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        public static int CalculateEnergyDrinkers(int numberSurveyed)
        {
            double result;
            result = numberSurveyed * PurchasedEnergyDrinks;
            return Convert.ToInt32(result);

        }

        public static int CalculatePreferCitrus(int numberSurveyed)
        {
            double result;
            result = numberSurveyed * PreferCitrusDrinks;
            return Convert.ToInt32(result);
        }


        private static void Main(string[] args)
        {

            int drinkers = CalculateEnergyDrinkers(NumberedSurveyed);
            int preferCitrus = CalculatePreferCitrus(NumberedSurveyed);
            Console.WriteLine($"Total number of people surveyed {NumberedSurveyed}");
            Console.WriteLine($"Approximately {drinkers} bought at least one energy drink");
            Console.WriteLine($"{preferCitrus} of those prefer citrus flavored energy drinks.");
            Console.ReadKey();
        }
    }
}
