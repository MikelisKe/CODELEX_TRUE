internal class Program
{
    private static void Main(string[] args)
    {
        string sentence = "My name is Mikelis Keiss and im born in 1990";
        string[] words = sentence.Split(' ');
        string name = words[3];
        int birthYear = Int16.Parse(words[9]);

        Console.WriteLine(name);
        Console.WriteLine(birthYear);
        Console.WriteLine($"My name is {name}, and im born in {birthYear}");
        Console.ReadKey();
    }
}