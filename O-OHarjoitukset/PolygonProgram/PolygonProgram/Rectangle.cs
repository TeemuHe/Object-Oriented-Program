using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonProgram
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width, string type, string color)
            : base(type, color)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return base.ToString() + $"Pituus: {Length}\tLeveys: {Width}\tPinta-ala: {GetArea():F2}\t";
        }
    }
}
