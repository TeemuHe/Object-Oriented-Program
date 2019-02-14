using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonProgram
{
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override string ToString()
        {
            return $"Suorakulmion korkeus on {this.length} ja leveys {this.width}.";
        }

        public double GetArea()
        {
            double area = 0;
            area = length * width;
            return area;
        }

        public void GetInfo()
        {
            GetArea();
            Console.WriteLine($"Suorakulmion pinta-ala on {GetArea():F2}");
        }
    }
}
