namespace Exercise_3;

public class Odometer
{
    public int _currentOdeometer;
    private FuelGauge _fuelGauge;

    public Odometer()
    {
        _currentOdeometer = 0;
        _fuelGauge = FuelGauge;
    }

    public int Report()
    {
        return _currentOdeometer;
    }

    public void Drive()
    {
        if (_currentOdeometer < 999999)
        {
            _currentOdeometer++;
        }
        else
        {
            _currentOdeometer = 0;
        }

    }
}