using System;
using System.Collections.Generic;
using System.Linq;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            Dictionary<char, char> keyboard = new Dictionary<char, char>()
            {
                { '!', '1' },
                { '@', '2' },
                { '#', '3' },
                { '$', '4' },
                { '%', '5' },
                { '^', '6' },
                { '&', '7' },
                { '*', '8' },
                { '(', '9' },
                { ')', '0' },
            };


            var decryptedNumbers = cryptedNumbers.Select(x => new string(x.Select(c => keyboard.ContainsKey(c) ? keyboard[c] : c).ToArray())).ToList();

            /*foreach (var cryptedNumber in cryptedNumbers)
            {
                string decryptedNumber = "";
                foreach (char c in cryptedNumber)
                {
                    if (keyboard.ContainsKey(c))
                    {
                        decryptedNumber += keyboard[c];
                    }
                    else
                    {
                        decryptedNumber += c;
                    }
                }
                decryptedNumbers.Add(decryptedNumber);
            }*/

            foreach (var crypt in decryptedNumbers)
            {
                Console.WriteLine(crypt);
            }


            Console.ReadKey();
        }
    }
}
            
    

