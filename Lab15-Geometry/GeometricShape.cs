using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15_Geometry
{
    interface GeometricShape : Object2DMoveOnAxisX, Object2DMoveOnAxisY
    {
        public Coordinates2D[] Points { get; }

        public ShapeType ShapeType { get; }

        public void PrintPointsCoords();
    }
}
