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
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();           
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
                default: 
                    return "invalid output";
            }
        }

        public static void CalculateCircleArea()
        {            
            decimal radius = 0;
            Console.WriteLine("What is the circle's radius? ");
           
            radius = decimal.Parse(Console.ReadLine());                      
            Console.WriteLine($"The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;
            Console.WriteLine("Enter length? ");            
            length = decimal.Parse(Console.ReadLine());            
            Console.WriteLine("Enter width? ");            
            width = decimal.Parse(Console.ReadLine());            
            double rectArea = Geometry.AreaOfRectangle( length, width);
            Console.WriteLine($"The rectangle's area is {rectArea}");                           
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal h = 0;
            
            Console.WriteLine("Enter length of the triangle's base? ");
            
            var triangleG = Console.ReadLine();
            ground = Convert.ToInt32(triangleG);
            
            Console.WriteLine("Enter triangle's height? ");           

            var triangleH = Console.ReadLine();
            h = Convert.ToInt32(triangleH);                      
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, h));
        }
    }
}
