using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonProgram
{
    abstract class Shape
    {
        public abstract double GetArea();

        /*private string type;
        private string color;*/

        public string Type { get; set; }
        public string Color { get; set; }

        protected Shape(string type, string color)
        {
            Type = type;
            Color = color;
        }

        public string GetColor()
        {
            return this.Color;
        }

        public override string ToString()
        {
            return $"Muoto: {Type}\tVäri: {Color}\t";
        }
        public void GetInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
