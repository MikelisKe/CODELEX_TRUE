using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( GetMenu());
           Console.ReadKey();
        }

        public static string GetMenu()
        {

            string userChoice;


            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            // get input from user
            switch (keyboard.KeyChar)
            {
                case '1':
                    CalculateCircleArea();
                    return keyboard.KeyChar.ToString();
                case '2':
                    CalculateRectangleArea();
                    return keyboard.KeyChar.ToString();
                case '3':
                    CalculateTriangleArea();
                    return keyboard.KeyChar.ToString();
                case '4':
                    break;
            }
             return "invlid output";
            // validate input

            return "invalid input";
        }

        public static void CalculateCircleArea()
        {
            // Get input from user
            decimal radius = 0;
            Console.WriteLine("What is the circle's radius? ");
            //todo
            radius = decimal.Parse(Console.ReadLine());

            decimal circleArea = Convert.ToDecimal(Math.PI) * radius * 2;

            // Display output
            Console.WriteLine($"The circle's area is {circleArea} "
                    + Geometry.AreaOfCircle(radius));

        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            // Get input from user

            // Get length
            Console.WriteLine("Enter length? ");
            //todo
            length = decimal.Parse(Console.ReadLine());
            // Get width
            Console.WriteLine("Enter width? ");
            //todo
            width = decimal.Parse(Console.ReadLine());
            // Display output
            double rectArea = Geometry.AreaOfRectangle( length, width);
            Console.WriteLine($"The rectangle's area is {rectArea}");
                           
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal h = 0;

            // Get input from user

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            //todo
            //read key
            var triangleG = Console.ReadLine();
            ground = Convert.ToInt32(triangleG);

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            //todo
            //read key value

            var triangleH = Console.ReadLine();
            h = Convert.ToInt32(triangleH);
            // Display the triangle's area.
            double triArea = Geometry.AreaOfTriangle( ground, h);
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, h));
        }
    }
}
