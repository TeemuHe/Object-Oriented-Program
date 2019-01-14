using System;

namespace CompanyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firmaluokka");

            Company company = new Company();
            company.Title("Firma Oy", "Keskuskatu 3", "040 1234567", 0, 0);
            company.Income();
            company.Profit();
        }
    }
}
