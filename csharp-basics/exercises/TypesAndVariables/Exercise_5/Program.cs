using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int rowLine = 36;
        string sym = "-";
        string class1, class2;
        string teacher1, teacher2;
        teacher1 = "Mr.PooPoo";
        teacher2 = "Mrs.PeePee";
        class1 = "Pooping";
        class2 = class1 + "right";
        int val1 = (int)(10 - class1.Length);

        string line1 = ($"|{"1",0}|{class1,13}|{teacher1,21}|");
        string line2 = ($"|{"2",0}|{class2,13}|{teacher2,21}|");

        for (int i = 0; i < rowLine; i++)
        {
            sym += "-";
        }
        Console.WriteLine("+" + sym + "+"); //38
        Console.WriteLine(line1);
        Console.WriteLine(line2);
        Console.WriteLine("+" + sym + "+");

    }
}