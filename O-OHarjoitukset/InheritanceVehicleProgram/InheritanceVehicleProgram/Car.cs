using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVehicleProgram
{
    class Car : Vehicle
    {
        protected string type;
        protected double engine;
        protected string doors;

        public Car()
        {
            this.type = "";
            this.engine = 0;
            this.doors = "";
        }

        public Car(string brand, string model, string year, string price, double engine, string type, string doors):
                    base(brand, model, year, price)
        {
            this.type = type;
            this.engine = engine;
            this.doors = doors;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Moottori: {this.engine} l\nTyyppi: {this.type}\nOvien lukumäärä: {this.doors}");
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(Object obj)
        {
            Car carObj = obj as Car;

            if(carObj == null)
            {
                return false;
            }
            else
            {
                return this.brand.Equals(carObj.brand);
            }
        }
    }
}
