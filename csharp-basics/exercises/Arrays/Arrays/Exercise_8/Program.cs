internal class Program
{
    private static void Main(string[] args)
    {         
        string[] words = { "fanta", "cola" };
        
        Random rnx = new Random();
        int randNum = rnx.Next(words.Length);
        string randomWord = words[randNum].ToLower();
        Console.WriteLine(randomWord);
        string underLine = "";
        int missCount = randomWord.Length * randomWord.Length;
        string misses = null;
        int randcount = randomWord.Length;

        Console.WriteLine("Welcome to Hangman");
        Console.Write("Enter your first letter:");

        for (int i = 0; i < randomWord.Length; i++)
        {
            underLine += "_";
        }

        while (missCount !=0 && randcount !=0)   
        {
            char guess = Console.ReadKey().KeyChar;
            bool match = false;

            for (int i = 0 ; i < randomWord.Length ; i++ )
            {
                if (guess == randomWord[i])
                {
                    underLine = underLine.Substring(0, i) + guess.ToString() + underLine.Substring(i +1);
                    match = true;
                }
            }

            if (!match)
            {
                missCount--;
                misses += guess;
            }

            Console.WriteLine();
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine();
            Console.WriteLine($"word: {underLine}");
            Console.WriteLine();
            Console.WriteLine($"Misses : {misses}");
            Console.WriteLine();
            Console.WriteLine($"Guess :  {guess}");

            if (randomWord == underLine)
            {
                Console.WriteLine("congrats! You win");
                break;
            }
        }    
    }
}