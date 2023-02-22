internal class Program
{
    static bool Prime(int num)
    {
        
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {

                Console.WriteLine($"{num} is not the prime with divider {i}");
                return false;
            }
        }

        Console.WriteLine($"This {num} is a prime");
        return true;
    }

        private static void Main(string[] args)
    {   
        Console.Write("insert the number to check if it is a Harshad number:");
        var num = Convert.ToInt32( Console.ReadLine());
        int numSum =0;
        int numH = num;        

        while (num !=0)
        {
            int s = num % 10;
            num /= 10 ;
            numSum += s;                        
        }
        int har = numH / numSum;
        Console.WriteLine(har);
        if (numH % numSum ==0) 
        {
            Console.WriteLine($"This number {numH} is Harshad number");
        }
        else
        {
            Console.WriteLine($" {numH} not the Harsad  number");
        }

         if (Prime(har) ==true ){
            Console.WriteLine("num is prime");
        }
         else { Console.WriteLine("num is not prime");
        }        
    }
}