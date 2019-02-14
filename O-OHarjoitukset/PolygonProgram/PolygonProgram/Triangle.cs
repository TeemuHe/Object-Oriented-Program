using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonProgram
{
    class Triangle : Shape
    {
        private double length;
        private double width;

        public Triangle(double length, double width, string shape, string color)
            :base (shape, color)
        {
            this.length = length;
            this.width = width;
        }

        public override string ToString()
        {
            return $"Kolmion korkeus on {this.length} ja leveys {this.width}.";
        }

        public double GetArea()
        {
            double area = 0;
            area = (length * width) /2;
            return area;
        }

        public void GetInfo()
        {
            GetArea();
            Console.WriteLine($"Kolmion pinta-ala on {GetArea():F2}.");
        }
    }
}
