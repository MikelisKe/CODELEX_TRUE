internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please input your weight");
        int weight = int.Parse(Console.ReadLine());
        Console.WriteLine("now height");
        double height = double.Parse(Console.ReadLine());
        double bmi = weight/ (height*height);

        if (bmi <=18.5) 
        {
            Console.WriteLine($"Your bmi is {bmi} and you need to gain some weight");
        }
        else if(bmi > 18.5 && bmi < 25)
        {
            Console.WriteLine($"Your bmi is {bmi} and you`re ok");
        }
        else if (bmi > 25)
        {
            Console.WriteLine($"Your bmi is {bmi} you`re like me - fat");
        }
    }
}