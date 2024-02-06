using System;

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new("red");

        Square square = new("blue", 5);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());
        Circle circle = new("green", 3);
        Rectangle rectangle = new("yellow", 3, 4);


        List<Shape> shapes = new()
        {
            shape,
            square,
            circle,
            rectangle
        };

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetType());
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
            Console.WriteLine();
        }
    }
}