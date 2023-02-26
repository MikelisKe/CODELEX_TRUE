internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] arrayOfTen = new int[10];

        for (int i = 0; i < arrayOfTen.Length; i++)
        {
            arrayOfTen[i] = rnd.Next(100);
        }

        for (int i = 0; i < arrayOfTen.Length; i++)
        {
            Console.Write(arrayOfTen[i] + " ");
        }

        Console.WriteLine( "\n");
        int[] copyOfArray = arrayOfTen;
        copyOfArray[9] = -7;

        for (int i = 0; i < copyOfArray.Length; i++)
        {
            Console.Write(arrayOfTen[i] + " ");
        }

        Console.ReadKey();
        }
}