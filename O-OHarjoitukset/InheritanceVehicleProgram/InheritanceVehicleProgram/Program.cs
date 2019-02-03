using System;

namespace InheritanceVehicleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ajoneuvo");

            Car car = new Car("Tojota", "Avensis", "2005", "10000", 1.8, "Sedan", "5");

            car.PrintInfo();

            car.ToString();
            car.Equals(1);
            Console.WriteLine("Kuorma-auto");
            Truck truck = new Truck(200, 0.25);
            truck.PrintTruckInfo();
            truck.CountConsumption();
        }
    }
}
