using System;
using System.Collections.Generic;

namespace InterfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("-------------------");

            Product product = new Product("Vasara",7.5,4);
            //Console.WriteLine(product.GetProduct("Vasara"));
            //Console.Write("Kokonaishinta: ");
            //Console.WriteLine(product.CalculateTotal());

            List<Product> prodList = new List<Product>()
            {
                new Product("Vasara", 7.5,4),
                new Product("Käsisaha", 12.5, 3),
                new Product("Lapio", 9.95,5),
                new Product("Kirves", 15.45, 2)
            };

            prodList.ForEach(Console.WriteLine);
        }
    }
}
