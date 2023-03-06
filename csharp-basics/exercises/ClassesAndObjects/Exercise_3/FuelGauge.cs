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

    public void incrementFuel(int fuel)
    {
        int ammount = 0;
        if (fuel < maxFuel)
        {
              += ammount;
        }
        else
        {
            Console.WriteLine("im full");
        }
    }

    public void Drive(int fuel, int odo)
    {
        for (int i = 0; i < fuel; i++)
        {
            if (i < fuel)
            {
                Console.WriteLine($"Brummbrumm... {i}  km gone");
                fuel--;
                odo+=10;
            }
            else
            {
                Console.WriteLine("Your out of gas");
            }

            
        }
    }

    /* ammont of fuel
    increment the fuel
    max fuel = 70
    decrement if fuel is > 0 as car runs
    */
}