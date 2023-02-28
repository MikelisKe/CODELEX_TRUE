internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, -8, 9, 10, -11, 12, 13, -14, };
        int positive = 0;
        int negative = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                positive += numbers[i];
            }
            else if (numbers[i] < 0)
            {
                negative -= numbers[i];
            }
        }
        Console.WriteLine($"Number sum of positive numbers - {positive}");
        Console.WriteLine($"Number sum of negative numbers - {negative}");
    }
}