using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab15_Geometry
{
    class Rectangle : GeometricShape
    {
        public Rectangle(Coordinates2D topLeftCornerCoords, float length, float height)
        {
            TopLeftCorner = topLeftCornerCoords;
            Length = length;
            Height = height;

            CalculatePoints();
        }

        private Coordinates2D TopLeftCorner { get; }
        private float Length { get; }
        private float Height { get; }

        public ShapeType ShapeType { get { return ShapeType.Rectangle; } }

        public Coordinates2D[] Points { get; private set; }

        private void CalculatePoints()
        {
            Coordinates2D topRightCorner;
            Coordinates2D bottomRightCorner;
            Coordinates2D bottomLeftCorner;

            topRightCorner.x = TopLeftCorner.x + Length;
            topRightCorner.y = TopLeftCorner.y;

            bottomRightCorner.x = topRightCorner.x;
            bottomRightCorner.y = topRightCorner.y - Height;

            bottomLeftCorner.x = TopLeftCorner.x;
            bottomLeftCorner.y = bottomRightCorner.y;

            Points = new Coordinates2D[] { TopLeftCorner, topRightCorner, bottomRightCorner, bottomLeftCorner };
        }

        public void PrintPointsCoords()
        {
            int counter = 0;

            Console.WriteLine($"{ShapeType}:");
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
