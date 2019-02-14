using System;
using System.Collections.Generic;

namespace PolygonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MonikulmioTask");

            Circle circle = new Circle(3,"Ympyrä", "Keltanen");
            Rectangle rectangle = new Rectangle(4,2,"Suorakulmio", "Vihreä");
            Triangle triangle = new Triangle(5,8, "Kolmio", "Valkonen");

            List<Shape> polygons = new List<Shape>();
            polygons.Add(circle);
            polygons.Add(rectangle);
            polygons.Add(triangle);

            foreach(var Shape in polygons)
            {
                circle.GetInfo();
                rectangle.GetInfo();
                triangle.GetInfo();
            }
        }
    }
}
