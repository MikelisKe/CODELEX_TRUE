using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> myHashSet = new HashSet<string>();

        myHashSet.Add("One");
        myHashSet.Add("Two");
        myHashSet.Add("Three");
        myHashSet.Add("Four");
        myHashSet.Add("Five");

        Console.WriteLine("Displaying all items:");
        foreach (string item in myHashSet)
        {
            Console.WriteLine(item);
        }

        myHashSet.Clear();
        Console.WriteLine("Removed all values from the set");

        Console.WriteLine("Trying to add a duplicate value to the HashSet:");
        if (!myHashSet.Add("Two"))
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
