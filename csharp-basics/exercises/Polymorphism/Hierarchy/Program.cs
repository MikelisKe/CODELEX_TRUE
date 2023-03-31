using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Andis = new Person("Andis", "Pepe", "Lauvas 13", 123);

            var info = Andis.DisplayPerson();
            Console.WriteLine(info);

            Student Ludi = new Student("Ludis", "Budis", "Silicon Valley", 321);
            Ludi.Ggpa(5.5);
            
            Console.WriteLine(Ludi.DisplayPerson());
          

            Emplyee Loco = new Emplyee("Loco", "Boco", "Booland", 007);
            Loco.GetJob("Gardener");
            Console.WriteLine(Loco.DisplayPerson());

            Console.ReadKey();
        }
    }
}