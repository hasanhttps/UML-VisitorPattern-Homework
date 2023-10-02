using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class AreaCalculator : IVisitor
    {
        public void Visit(Circle circle)
        {
            double area = Math.PI * circle.Radius * circle.Radius;
            Console.WriteLine($"Area of Circle: {area}");
        }

        public void Visit(Square square)
        {
            double area = square.SideLength * square.SideLength;
            Console.WriteLine($"Area of Square: {area}");
        }

        public void Visit(Triangle triangle)
        {
            double area = 0.5 * triangle.Base * triangle.Height;
            Console.WriteLine($"Area of Triangle: {area}");
        }
    }
}
