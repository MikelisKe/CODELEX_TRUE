internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
        Random rnd = new Random();
        int number = rnd.Next(1, 100);
        int guess = Convert.ToInt32(Console.ReadLine());
        while (guess != number)
        {
            if (number == guess)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
                break;
            }
            else if (number > guess)
            {
                Console.WriteLine($"Sorry, you are too low.  Try again");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too high. Try again");
            }
            guess = Convert.ToInt32(Console.ReadLine());
        }
    }
}