using System;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Input word to get it into your Nokia 3310");
        var text = Console.ReadLine();
        string textLower = text.ToLower();
        int pad;
        

        if (textLower == null)
        {
            Console.WriteLine("You forgot to input something");
        }
        else if (textLower.Any(char.IsDigit))
        {
            Console.WriteLine("You put the digits in there");
        }
        else
        {
            for (int i = 0; i < textLower.Length; i++)
                               
                switch (textLower[i])
                {
                    case 'a': case 'b': case 'c':
                        Console.WriteLine(2); break;
                    case 'd': case 'e': case 'f':
                        Console.WriteLine(3); break;
                    case 'g': case 'h': case 'i':
                        Console.WriteLine(4); break;
                    case 'j': case 'k': case 'l':
                        Console.WriteLine(5); break;
                    case 'm': case 'n': case 'o':
                        Console.WriteLine(6); break;
                    case 'p': case 'q': case 'r': case 's':
                        Console.WriteLine(7); break;
                    case 't': case 'u': case 'v':
                        Console.WriteLine(8); break;
                    case 'w': case 'x': case 'y': case 'z':
                        Console.WriteLine(9); break;                


                }
            }
        }       
    }
