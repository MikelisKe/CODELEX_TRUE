using System;

namespace Exercise4
{
    class Program
    {
        //TODO: print all vowels using for and foreach
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            //todo - use for
            for(int i = 0; i < vowels.Length; i++)
            {
                Console.Write(vowels[i]+ " ");
            }

            Console.WriteLine();

            foreach (char vowel in vowels)
            {
                Console.Write(vowel + " ");
            }
            //todo - use foreach
            Console.ReadKey();
        }
    }
}
