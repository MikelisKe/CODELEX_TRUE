using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory janka = new PhoneDirectory("Janka", "9091001");
            janka.PutNumber("Slaists", "29091003");
            janka.PutNumber("Ruta", "29091002");
            Console.WriteLine(janka.GetNumber("Ruta"));
            foreach (var v in janka._data)
            {
                Console.WriteLine($"{v.Key} {v.Value}");
            }

            Console.ReadKey();
        }
    }
}
