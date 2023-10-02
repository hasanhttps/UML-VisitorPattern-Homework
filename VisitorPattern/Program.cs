namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
        {
            new Circle(5),
            new Square(4),
            new Triangle(3, 4)
        };

            AreaCalculator areaCalculator = new AreaCalculator();
            PerimeterCalculator perimeterCalculator = new PerimeterCalculator();

            foreach (var shape in shapes)
            {
                shape.Accept(areaCalculator);
                shape.Accept(perimeterCalculator);
            }
        }
    }

}