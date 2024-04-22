using System.Threading.Channels;
using Exercise_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product("Logitech mouse", 70.00, 14);
        Product product2 = new Product("iPhone 5s", 999.99, 3);
        Product product3 = new Product("Epson EB-U05", 440.46, 1);
        
        Console.WriteLine(product1.ToString());
        Console.WriteLine(product2.ToString());
        Console.WriteLine(product3.ToString());

        Console.WriteLine(product3.ChangePrice());
        Console.WriteLine(product3.ChangeQuantitity());
        
        Console.WriteLine(product3.ToString());

        Console.ReadKey();
    }
}