using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVehicleProgram
{
    class Truck : Car
    {
        protected double weightOfCargo;
        protected double consumptionPerKg;

        public Truck()
        {
            this.weightOfCargo = 0;
            this.consumptionPerKg = 0;
        }
        public Truck(double weightOfKuorma, double wastePerKg)
        {
            this.weightOfCargo = weightOfKuorma;
            this.consumptionPerKg = wastePerKg;
        }
        public void PrintTruckInfo()
        {
            Console.WriteLine($"Kuorman paino: {this.weightOfCargo} kg\nKulutus per kg: {this.consumptionPerKg} l");
        }
        public void CountConsumption()
        {
            Console.WriteLine($"{this.weightOfCargo} kg:n kuorman tuoma lisäkulutus on {this.weightOfCargo * this.consumptionPerKg} litraa.");
        }
    }
}
