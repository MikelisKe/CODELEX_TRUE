internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Desired sum = 9");
        Random rnd = new Random();
        int desired = 9;
        int counter = 1;
        int iterations = 0;

        for(int i = 0; i < counter; i++) 
        {
            int x = rnd.Next(1,7);
            int y = rnd.Next(0,7);
            int z = x + y;
            if(x + y != 9)
            {
                Console.WriteLine($"{x} and {y} = {z}");
                counter++;
                iterations++;
            }
            else
            {
                Console.WriteLine($"{x} and {y} = {z}");
                Console.WriteLine($"Yougot lucky after {iterations} times ");
            }
        }

        Console.ReadKey();
    }
}