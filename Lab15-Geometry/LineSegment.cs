using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Lab15_Geometry
{
    class LineSegment : GeometricShape
    {
        public LineSegment(Coordinates2D a, Coordinates2D b)
        {
            Points = new Coordinates2D[] { a, b };
        }

        public ShapeType ShapeType { get { return ShapeType.LineSegment; } }

        public Coordinates2D[] Points { get; private set; }

        public void PrintPointsCoords()
        {
            int counter = 0;

            Console.Write($"{ShapeType}: ");
            foreach (Coordinates2D point in Points)
            {
                counter++;

                Console.Write($"Point {counter}: ");
                Console.WriteLine($"X: {point.x}, Y: {point.y}");
            }
        }

        void Object2DMoveOnAxisX.MoveX(float distance)
        {
            // De ce nu merge cu foreach?
            //foreach (Coordinates2D point in Points)
            //{
            //    point.X += distance;
            //}
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].x += distance;
            }
        }

        void Object2DMoveOnAxisY.MoveY(float distance)
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].y += distance;
            }
        }
    }
}
