using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class PerimeterCalculator : IVisitor
    {
        public void Visit(Circle circle)
        {
            double perimeter = 2 * Math.PI * circle.Radius;
            Console.WriteLine($"Perimeter of Circle: {perimeter}");
        }

        public void Visit(Square square)
        {
            double perimeter = 4 * square.SideLength;
            Console.WriteLine($"Perimeter of Square: {perimeter}");
        }

        public void Visit(Triangle triangle)
        {
            double perimeter = 3 * triangle.Base;
            Console.WriteLine($"Perimeter of Triangle: {perimeter}");
        }
    }
}
