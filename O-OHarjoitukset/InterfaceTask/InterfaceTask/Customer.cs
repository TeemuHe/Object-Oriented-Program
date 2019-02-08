using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    class Customer : ICustomer
    {
        private string _customerName;
        private double _purchases;

        public Customer(string customerName, double purchases)
        {
            this._customerName = customerName;
            this._purchases = purchases;
        }

        public override string ToString()
        {
            return $"{this._customerName}, {this._purchases}";
        }

        public Object GetCustomer(string customerName)
        {
            if(this._customerName == customerName)
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
            if (_purchases <= 1000)
            {
                bonus = 0.02 * _purchases;
            }
            else if(_purchases > 1000 && _purchases <= 2000)
            {
                bonus = 0.03 * _purchases;
            }
            else
            {
                bonus = 0.05 * _purchases;
            }
            //Console.WriteLine($"ok{bonus}");
            return bonus;
        }
         public void PrintInfo(double bonus)
        {
            Console.WriteLine($"Asiakas: {this._customerName}\nOstosten summa: {this._purchases:C}\n" +
                $"Saatu boonus: {this.GetBonus():C}");
        }
    }
}
