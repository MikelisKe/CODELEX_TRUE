internal class PrintDayInWord
{
    static void NestedIf()
    {
        Console.WriteLine("Input number from 0 to 6 to know the day");
        var input = int.Parse(Console.ReadLine());

        if (input < 0 || input > 6)
        {
            Console.WriteLine("Invalid input, try again");
        }
        else
        {
            if (input == 0)
            {
                Console.WriteLine("Its Monday");
            }
            else if (input == 1)
            {
                Console.WriteLine("it`s Tuesday");
            }
            else if (input == 2)
            {
                Console.WriteLine("it`s Wednesday");
            }
            else if (input == 3)
            {
                Console.WriteLine("it`s Thursday");
            }
            else if (input == 4)
            {
                Console.WriteLine("it`s Friday");
            }
            else if (input == 5)
            {
                Console.WriteLine("it`s Saturday");
            }
            else if (input == 6)
            {
                Console.WriteLine("it`s Sunday");
            }
        }
    }

    static void Case()
    {
        Console.WriteLine("Input number from 0 to 6 to know the day");
        var input = int.Parse(Console.ReadLine());

        if (input < 0 || input > 6)
        {
            Console.WriteLine("Invalid input, try again");
        }
        else
        {
            switch (input)
            {
                case 0: Console.WriteLine("Monday"); break;
                case 1: Console.WriteLine("Tuesday"); break;
                case 2: Console.WriteLine("Wednesday"); break;
                case 3: Console.WriteLine("Thursday"); break;
                case 4: Console.WriteLine("Friday"); break;
                case 5: Console.WriteLine("Saturday"); break;
                case 6: Console.WriteLine("Sunday"); break;
            }
        }
    }

    private static void Main(string[] args)
    {        
        NestedIf();
        Case();        
    }
}