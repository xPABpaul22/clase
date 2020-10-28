using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Geometry
    {
        public static double GetVector2DLength(double x, double y)
        {
            double aux, length;
            aux = x * x + y * y;
            length = System.Math.Sqrt(aux);
            return length;
        }
        public static double GetVector3DLength(double x, double y, double z)
        {
            double aux, length;
            aux = x * x + y * y + z * z;
            length = System.Math.Sqrt(aux);
            return length;
        }
        public static double GetCircleArea(double radius)
        {
            double area;
            area = System.Math.PI * (radius * radius);
            return area;
        }
        public static double GetRectangleArea(double width, double height)
        {
            double area;
            area = width * height;
            return area;
        }
        public static double GetEllipseArea(double radius1, double radius2)
        {
            double area;
            area = System.Math.PI * radius1 * radius2;
            return area;
        }
    }
}
