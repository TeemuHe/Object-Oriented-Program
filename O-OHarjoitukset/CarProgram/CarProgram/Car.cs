using System;
using System.Collections.Generic;
using System.Text;

namespace CarProgram
{
    class Car
    {
        public string brand;
        public double speed;
        public double extraSpeed;

        public void AskData()
        {
            Console.Write("Syötä merkki: ");
            brand = Console.ReadLine();
            Console.Write("Nopeus: ");
            speed = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki: {this.brand}\nAuton nopeus: {this.speed}");
            Console.Clear();
        }
        public void Accelerate()
        {
            do
            {
                Console.Write($"Paljonko nopeutta lisätään {this.brand}lle ? ");
                extraSpeed = int.Parse(Console.ReadLine());
                if(extraSpeed < 0)
                {
                    Console.WriteLine("Syötä positiivinen luku!");
                }
                this.speed += extraSpeed;
            } while (extraSpeed <= 0);
            Console.WriteLine($"{this.brand} kiihdyttää ja kulkee lopulta {this.speed}km/h.");
        }
        public void Brake()
        {
            Console.WriteLine($"Nyt {this.brand} hidastaa ja kulkee {this.speed * 0.9}km/h.");
        }
    }
}
