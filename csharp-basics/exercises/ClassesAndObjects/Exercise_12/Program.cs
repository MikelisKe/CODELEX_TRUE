﻿using Exercise_12;

internal class Program
{
    public static void Main(string[] args)
    {

        TestPaper paper1 = new TestPaper("Math", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
        TestPaper paper2 = new TestPaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
        TestPaper paper3 = new TestPaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");

        Student student1 = new Student();
        Student student2 = new Student();

        student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });

        student2.TakeTest(paper2, new string[] { "1C", "2D", "3A", "4C" });
        student2.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
        
        Console.ReadKey();
    }
}
