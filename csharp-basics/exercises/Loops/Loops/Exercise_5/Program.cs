using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("insert first word:");
        string firstWord = Console.ReadLine();
        Console.WriteLine("insert second word:");
        string secondWord = Console.ReadLine();
        int firsLength = firstWord.Length;
        int secondLength = secondWord.Length;
        char[] dots = new char[30 - firsLength-secondLength];
        string dotsCount = "";

        for(int i = 0; i < dots.Length; i++)
        {
            dotsCount += '.';
        }

        Console.WriteLine($"{firstWord}{dotsCount}{secondWord}");
    }
}