using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();

            Car tank = new Car(0);
            Car hybridCar = new Car(0);

            for (int i = 0; i < 1; i++)
            {
                Console.Write("Enter first reading for tank: ");
                tank._endKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading for tank: ");
                tank._liters = Convert.ToInt32(Console.ReadLine());
                tank.FillUp(tank._endKilometers-tank._startKilometers, tank._liters);

                Console.Write("Enter first reading for hybrid: ");
                hybridCar._endKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading for hybrid: ");
                hybridCar._liters = Convert.ToInt32(Console.ReadLine());
                hybridCar.FillUp(hybridCar._endKilometers - hybridCar._startKilometers, hybridCar._liters);
            }

            Console.WriteLine("Kilometers per liter are " + tank.CalculateConsumption() + " gasHog:" + tank.GasHog());
            Console.WriteLine("hybridCar Kilometers per liter are " + hybridCar.CalculateConsumption() + " economyCar:" + hybridCar.EconomyCar());
            Console.ReadKey();
        }
    }
}