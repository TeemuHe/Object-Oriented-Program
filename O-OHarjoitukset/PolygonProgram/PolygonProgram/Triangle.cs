using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonProgram
{
    class Triangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Triangle(double length, double width, string type, string color)
            :base (type, color)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width / 2;
        }

        public override string ToString()
        {
            return base.ToString() + $"Pituus: {Length}\tLeveys: {Width}\tPinta-ala: {GetArea():F2}\t";
        }
    }
}
