using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            double area = Math.PI * Convert.ToDouble(radius) * 2;
            return area;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            double areaRec = (double)(length * width);
            return areaRec;
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            double areaTri = (double)(ground * h) * (double)0.5;
            return areaTri ;
        }
    }
}
