using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15_Geometry
{
    static class GeometryUtils
    {
        public static float CalculatePerimeter (GeometricShape shape)
        {
            float perimeter = 0;

            if (shape.Points.Length < 2)
            {
                Console.WriteLine("GeometricShape does not have enough points (at least 2)");
                return 0;
            }

            for (int i = 0; i < shape.Points.Length; i++)
            {
                if ((i + 1) != shape.Points.Length)
                {
                    float a = shape.Points[i].x - shape.Points[i + 1].x;
                    float b = shape.Points[i].y - shape.Points[i + 1].y;
                    
                    if (a < 0)
                        a = -a;

                    if (b < 0)
                        b = -b;

                    float sqrtC = (a * a) + (b * b);

                    perimeter += MathF.Sqrt(sqrtC);
                }

                if (((i + 1) == shape.Points.Length) && shape.Points.Length > 2)
                {
                    float a = shape.Points[i].x - shape.Points[0].x;
                    float b = shape.Points[i].y - shape.Points[0].y;

                    if (a < 0)
                        a = -a;

                    if (b < 0)
                        b = -b;

                    float sqrtC = (a * a) + (b * b);

                    perimeter += MathF.Sqrt(sqrtC);
                }
            }

            Console.WriteLine($"{shape.ShapeType} Perimeter = {perimeter}");
            return perimeter;
        }

        public static void MoveX(GeometricShape[] shapes, float distance)
        {
            Console.WriteLine("Moving on X Axis");
            foreach (GeometricShape shape in shapes)
            {
                shape.MoveX(distance);
                shape.PrintPointsCoords();
            }
        }

        public static void MoveY(GeometricShape[] shapes, float distance)
        {
            Console.WriteLine("Moving on Y Axis");
            foreach (GeometricShape shape in shapes)
            {
                shape.MoveY(distance);
                shape.PrintPointsCoords();
            }
        }
    }
}
