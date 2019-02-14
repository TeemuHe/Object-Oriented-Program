using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonProgram
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override string ToString()
        {
            return $"Ympyrän säde on {this.radius}.";
        }

        public double GetArea()
        {
            double area = 0;
            area = radius * 3.1415926535;
            return area;
        }

        public void GetInfo()
        {
            this.GetArea();
            Console.WriteLine($"Ympyrän pinta-ala on {GetArea():F2}");
        }
    }
}
