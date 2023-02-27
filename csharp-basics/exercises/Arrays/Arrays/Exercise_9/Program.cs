using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] arr = { "AXE", "microphone", "stellar", "shape", "ship", "aeronaut" };
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i].ToLower();
        }

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = char.ToUpper(arr[i][0]) + arr[i].Substring(1);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+ ", ");
        }

    }
}