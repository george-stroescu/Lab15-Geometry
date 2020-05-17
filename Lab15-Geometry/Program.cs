using System;

namespace Lab15_Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            LineSegment line = new LineSegment(new Coordinates2D() { x = 15f, y = 3f }, new Coordinates2D() { x = 37f, y = 5f });
            Triangle triangle = new Triangle(new Coordinates2D() { x = 15f, y = 11f }, new Coordinates2D() { x = 18f, y = 15f }, new Coordinates2D() { x = 26f, y = 9f });
            Rectangle rectangle = new Rectangle(new Coordinates2D() { x = 15f, y = 3f }, 15f, 5f);

            Console.WriteLine();
            GeometryUtils.CalculatePerimeter(line);
            GeometryUtils.CalculatePerimeter(triangle);
            GeometryUtils.CalculatePerimeter(rectangle);

            Console.WriteLine();
            GeometryUtils.MoveX(new GeometricShape[] { line, triangle, rectangle }, 100);
            Console.WriteLine();
            GeometryUtils.MoveY(new GeometricShape[] { line, triangle, rectangle }, 100);
        }
    }
}