internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[100];
        for (int p = 0; p < arr.Length; p++)
        {
            arr[p] = p;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 20 == 0)
            {
                Console.Write("\n");
            }
            else if (arr[i] % 3 == 0 && arr[i] % 5 == 0)
            {
                Console.Write("FizzBuzz ");
            }
            else if (arr[i] % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            else if (arr[i] % 5 == 0)
            {
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write($"{i} ");
            }

        }



    }
}