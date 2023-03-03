using Exercise_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product("Banana", 1.1, 13);
        Product product2 = new Product("Logitech mouse", 70.00, 14);
        Product product3 = new Product("iPhone 5s", 999.99, 3);
        Product product4 = new Product("Epson EB-U05", 440.46, 1);

        Console.WriteLine(product1);
        Console.WriteLine(product2);
        Console.WriteLine(product3);
        Console.WriteLine(product4);
        Console.ReadKey();
    }
}