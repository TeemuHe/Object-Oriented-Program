using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyClass
{
    class Company
    {
        public string title;
        public string address;
        public string phoneNumber;
        public double income;
        public double extense;

        public Company()
        {
            this.title = "";
            this.address = "";
            this.phoneNumber = "";
            this.income = 0;
            this.extense = 0;
        }

        public Company(string title, string address, string phoneNumber, double income, double extense)
        {
            this.title = title;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.income = income;
            this.extense = extense;
        }

        public void Income()
        {
            Console.WriteLine($"{title}\n{address}\n{phoneNumber}");

            Console.Write("Syötä firman tulot: ");
            income = int.Parse(Console.ReadLine());
            Console.Write("Syötä firman menot: ");
            extense = int.Parse(Console.ReadLine());
        }

        public void Profit()
        {


            double profitPercent = (income - extense) / extense * 100;
            Console.WriteLine($"Firman voittoprosentti on {profitPercent:F0}%.");

            if(profitPercent < 100)
            {
                Console.WriteLine("Firmalla menee huonosti. Voittoprosentti on alle 100%.");
            }

            else if(profitPercent >= 100 && profitPercent < 200)
            {
                Console.WriteLine("Firmalla menee tyydyttävästi. Voittoprosentti on yli 100%.");
            }

            else if (profitPercent >= 200 && profitPercent < 300)
            {
                Console.WriteLine("Firmalla menee melko hyvin. Voittoprosentti on yli 200%.");
            }

            else if (profitPercent >= 300)
            {
                Console.WriteLine("Firmalla menee hyvin. Voittoprosentti on yli 300%.");
            }
        }
    }
}
