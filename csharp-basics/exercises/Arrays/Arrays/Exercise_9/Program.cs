using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] arr = { "AXE", "microphone", "stellar", "shape", "ship", "aeronaut" };
        string[] arr1 = { "Laptop", "mouse", "stuff", "more stuff", " another", "clipppper" };

        UpgradeArray(arr);
        UpgradeArray(arr1);

        foreach (string str in arr)
        {
            Console.Write($"{str}, ");
        }
        Console.WriteLine();
        foreach (string str in arr1)
        {
            Console.Write($"{str}, ");
        }
    }
    static void UpgradeArray(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i].Replace(" ", "");
            arr[i] = arr[i].ToLower();
            arr[i] = char.ToUpper(arr[i][0]) + arr[i].Substring(1);
        }
    }
}