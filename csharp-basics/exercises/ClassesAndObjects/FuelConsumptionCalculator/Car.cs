namespace FuelConsumptionCalculator
{
    public class Car 
    {
        public double _startKilometers;
        public double _endKilometers;
        public double _liters;
        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            var km = (_endKilometers - _startKilometers) / _liters;
            return km;
        }

        public double ConsumptionPer100Km()
        {
            var kmHundred = (_liters * 100) / (_endKilometers - _startKilometers);
            return kmHundred;
        }

        public bool GasHog() => ConsumptionPer100Km() > 15;

        public bool EconomyCar() => ConsumptionPer100Km() < 5;

        public void FillUp(double mileage, double liters)
        {
            mileage = _endKilometers - _startKilometers;
            liters += _liters;
        }
    }
}