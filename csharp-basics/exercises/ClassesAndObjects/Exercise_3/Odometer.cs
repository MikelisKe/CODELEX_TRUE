namespace Exercise_3;

public class Odometer
{
    private int _currentOdeometer;
    private FuelGauge _fuelGauge;

    public Odometer(int currentOdeometer, FuelGauge fuelGauge)
    {
        _currentOdeometer = currentOdeometer;
        _fuelGauge = fuelGauge;
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

        if (_currentOdeometer % 10 == 0)
        {
            _fuelGauge.Decrament();
        }
        

    }
}