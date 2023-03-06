using System.Diagnostics.Eventing.Reader;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        public double endKilometers;
        public double liters;
        public double startOdo;
        public Car(double startOdo, double endKilometers, double liters)
        {
            this.endKilometers = endKilometers;
            this.liters = liters;
        }

        public double CalculateConsumption(double startOdo, double endKilometers, double liters)
        {
            double result = (endKilometers - startOdo)/(60 - liters);
            return result;
        }

        private double ConsumptionPer100Km(double startOdo, double endKilometers, double liters)
        {
            double result = (100 - (endKilometers-startOdo)) / (60 - liters);
            return result;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {

        }
    }
}
