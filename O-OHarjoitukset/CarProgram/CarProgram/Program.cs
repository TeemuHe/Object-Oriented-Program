using System;

namespace CarProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Autot:");

            Car car = new Car();
            car.AskData();
            Car newCar = new Car();
            newCar.AskData();

            car.ShowCarInfo();
            newCar.ShowCarInfo();

            car.Accelerate();
            newCar.Accelerate();

            car.Brake();
            newCar.Brake();
        }
    }
}
