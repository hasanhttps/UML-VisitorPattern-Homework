using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(Circle circle);
        void Visit(Square square);
        void Visit(Triangle triangle);
    }
}
