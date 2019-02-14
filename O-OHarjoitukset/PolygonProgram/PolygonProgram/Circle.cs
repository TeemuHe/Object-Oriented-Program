using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonProgram
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, string type, string color)
            : base(type, color)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        public override string ToString()
        {
            return base.ToString() + $"Säde: {Radius}\tPinta-ala: {GetArea():F2}\t";
        }
    }
}
