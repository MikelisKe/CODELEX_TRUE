internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input two integers to solve the mistery:"); 
        int num = int.Parse(Console.ReadLine());
        int devider = 15;
        if (num == devider|| num % devider ==0)
        {
            Console.WriteLine(true);
        }                
        
        Console.ReadKey();
    }
}