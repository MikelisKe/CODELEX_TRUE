using Exercise_12;

internal class Program
{
    public static void Main(string[] args)
    {
        TestPaper math = new TestPaper("Math", new []{"1A", "2C", "3D", "4T", "5E"}, "60%");

        Student john = new Student();

        john.TakeTest(math, new []{ "1A", "2C", "3D", "4U", "5E" });
        Console.ReadKey();
    }
}
