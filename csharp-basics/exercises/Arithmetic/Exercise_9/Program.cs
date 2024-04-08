internal class Program
{
    private static void Main(string[] args)
    {

 
        Console.WriteLine("Please input your weight in kilograms(kg)");
        int weightInput = int.Parse(Console.ReadLine());        // SVARS kg
        Console.WriteLine("now height in centimeters (cm)");
        int heightInput = int.Parse(Console.ReadLine());        //Augums cm
        double weight = weightInput * 2.20462;
        double height = heightInput * 0.393701;
        double bmi = weight * 703 / (height * height);
        if (bmi <= 18.5) 
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