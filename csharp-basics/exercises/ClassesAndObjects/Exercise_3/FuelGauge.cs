namespace Exercise_3;

public class FuelGauge
{
    private int maxFuel;
    public int fuel;

    public FuelGauge(int maxFuel, int fuel)
    {
        this.maxFuel = maxFuel;
        this.fuel = fuel;
    }

    public void incrementFuel()
    {
        if (fuel == 70)
        {
            return;
        }

        fuel++;
    }

    public void Decrament()
    {
        fuel--;
    }

    public int FuelReport()
    {
        return fuel;
    }
}