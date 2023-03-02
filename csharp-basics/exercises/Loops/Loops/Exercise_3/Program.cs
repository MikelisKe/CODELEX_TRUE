using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] num = new int[21];
        Random rnd = new Random();

        for (int i = 0; i < num.Length; i++) 
        {
            num[i] = rnd.Next(0, 20);           
        }
        
        for (int i = 0;i < num.Length; i++)
        {
            Console.Write($"{num[i]} ");
        }

        Console.WriteLine();
        Console.Write("Select the number from 1 to 20 to know its index: ");
        int index = int.Parse(Console.ReadLine());

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == index)
            {
                Console.WriteLine($"The index or number {index} is {i} ");
            }            
        }        
    }
}