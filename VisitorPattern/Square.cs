using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Square : IShape
    {
        public double SideLength { get; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
