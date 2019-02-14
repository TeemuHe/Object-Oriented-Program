using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    class Customer : ICustomer
    {
        public string customerName;
        public double purchases;

        public Customer(string customerName, double purchases)
        {
            this.customerName = customerName;
            this.purchases = purchases;
        }

        public override string ToString()
        {
            return $"{this.customerName}, {this.purchases}";
        }

        public Object GetCustomer(string customerName)
        {
            if(this.customerName == customerName)
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public double GetBonus()
        {
            double bonus = 0;
            if (purchases <= 1000)
            {
                bonus = 0.02 * purchases;
            }
            else if(purchases > 1000 && purchases <= 2000)
            {
                bonus = 0.03 * purchases;
            }
            else
            {
                bonus = 0.05 * purchases;
            }
            //Console.WriteLine($"ok{bonus}");
            return bonus;
        }
         public void PrintInfo(double bonus)
        {
            Console.WriteLine($"Asiakas: {this.customerName}\nOstosten summa: {this.purchases:C}\n" +
                $"Saatu boonus: {this.GetBonus():C}");
        }
    }
}
