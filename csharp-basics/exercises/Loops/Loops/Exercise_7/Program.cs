internal class Piglet
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to piglet");
        int counter = 0;
        int loopCounter = 1;
        Random rnd = new Random();

        for (int i = 0; i < loopCounter; i++) 
        {
            if (rnd.Next(1,7)  != 1)
            {
                counter++;
                loopCounter++;
            }
            else
            {
                Console.WriteLine($"you got the score {counter}");
                Console.WriteLine("wanna play again y or n?"); ;
                if (Console.ReadKey().KeyChar == 'y')
                {
                    loopCounter++;
                    counter = 0;
                }
                else 
                {
                    break;
                }               
            }
        }       

    }
}