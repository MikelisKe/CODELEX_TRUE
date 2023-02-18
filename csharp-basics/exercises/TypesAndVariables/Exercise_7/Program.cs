internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a word where we can count upper case: ");
        string textToCountUppercase = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < textToCountUppercase.Length; i++)
        {
            if (Char.IsUpper(textToCountUppercase[i]))
                count++;
        }
        Console.WriteLine(count);
        Console.ReadKey();
    }
}