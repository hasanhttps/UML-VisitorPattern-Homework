using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Triangle : IShape
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
