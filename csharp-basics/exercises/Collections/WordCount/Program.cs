using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = System.IO.File.ReadAllText(@"C:\Users\Mikelis\Desktop\00_Darba maiņa\Codelex\CODELEX_LOCAL\csharp-basics\exercises\Collections\WordCount\lear.txt");
            Console.WriteLine(text);
            var lineCount = File.ReadAllLines(@"C:\Users\Mikelis\Desktop\00_Darba maiņa\Codelex\CODELEX_LOCAL\csharp-basics\exercises\Collections\WordCount\lear.txt").Length;
            Console.WriteLine(lineCount);
            var wordCount = text.Split(' ', '\t',',','?','!').Length;
            Console.WriteLine(wordCount);
            var symbolCount = text.Count() - 
                              text.Count(f => f == '!') - 
                              text.Count(f => f == '?') -
                              text.Count(f => f == '\t') - 
                              text.Count(f => f == ',');

            Console.WriteLine(symbolCount);

            Console.ReadLine();

        }
    }
}
