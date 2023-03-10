namespace Exercise_3;

public class FuelGauge
{
    public int _fuel;

    public FuelGauge(int fuel)
    {
        _fuel = fuel;
    }

    public void incrementFuel()
    {
        if (_fuel == 70)
        {
            return;
        }

        _fuel++;
    }

    public void Decrament()
    {
        _fuel--;
    }

    public int FuelReport()
    {
        return _fuel;
    }
}