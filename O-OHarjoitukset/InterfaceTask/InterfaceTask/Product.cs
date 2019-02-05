using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    class Product : IProduct
    {
        public string name;
        public double price;
        public int amount;

        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"Tuote: {this.name}      Hinta: {this.price:C}       Määrä: {this.amount}        Kokonaishinta: {this.price * this.amount:C}";
        }

        public Object GetProduct(string name)
        {
            if(this.name == name)
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public double CalculateTotal()
        {
            return this.price * this.amount;
        }
    }
}
