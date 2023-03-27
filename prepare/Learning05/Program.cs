using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 12);
        Rectangle rectangle = new Rectangle("red", 12, 24);
        Circle circle = new Circle("Purple", 10);
        List<Shape> shapes = new List<Shape>
        {
            {square}, {rectangle}, {circle}
        };

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}