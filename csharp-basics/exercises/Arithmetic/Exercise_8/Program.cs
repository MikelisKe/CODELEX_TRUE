internal class Program
{
    private static void Main(string[] args)
    {        
        double dollars1 = 7.50;
        double dollars2 = 8.20;
        double dollars3 = 10.00;
        int hours1 = 35;
        int hours2 = 47;
        int hours3 = 73;

        Console.WriteLine(CalculateSalary(dollars1, hours1));
        Console.WriteLine(CalculateSalary(dollars2, hours2));
        Console.WriteLine(CalculateSalary(dollars3, hours3));

        static string CalculateSalary (double basePay, int hoursWorked )
        {
            if (basePay < 8.00 || hoursWorked > 60)
            {
                return "The base pay must be at least $8.00 and the hours worked must be less than 60 hours per week.";
            }

            if (hoursWorked <= 40)
            {
                return (basePay*hoursWorked).ToString();
            }
            
            double salary = basePay * 40;
            salary = salary + (hoursWorked - 40.00) * (basePay* 1.5);
            return (salary).ToString ();
        }
    }
}