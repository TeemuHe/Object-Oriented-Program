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

            List<Customer> customersList = null;
            List<Product> productsList = null;
            Store store = new Store("Martin kauppa", 454545, customersList, productsList);

            Product hammer = new Product("Vasara",7.5,4);
            Product saw = new Product("Käsisaha", 12.5, 3);
            Product showel= new Product("Lapio", 9.95, 5);
            Product axe = new Product("Kirves", 15.45, 2);
            Customer firstCustomer = new Customer("Heikkinen", 2287);
            Customer secondCustomer = new Customer("Korhonen", 854);
            Customer thirdCustomer = new Customer("Virtanen", 1384);

            //Console.WriteLine(product.GetProduct("Vasara"));
            //Console.Write("Kokonaishinta: ");
            //Console.WriteLine(product.CalculateTotal());
            List<Product> prodList = new List<Product>
            {
                hammer,
                saw,
                showel,
                axe
            };
            List<Customer> custList = new List<Customer>();
            custList.Add(firstCustomer);
            custList.Add(secondCustomer);
            custList.Add(thirdCustomer);

            /*foreach (Product tool in prodList)
            {
                Console.WriteLine($"{tool.name} on listalla");
            }*/

            prodList.ForEach(Console.WriteLine);
            firstCustomer.GetCustomer("Heikkinen");
            firstCustomer.GetBonus();
            firstCustomer.PrintInfo(0);
            secondCustomer.GetCustomer("Korhonen");
            secondCustomer.GetBonus();
            secondCustomer.PrintInfo(0);
            thirdCustomer.GetCustomer("Virtanen");
            thirdCustomer.GetBonus();
            thirdCustomer.PrintInfo(0);
        }
    }
}
