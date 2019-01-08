using System;

namespace CatProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on kissa ohjelma.");

            Cat myFirstCat = new Cat("Pilli", 1);
            myFirstCat.IncreaseWeight(1);
            myFirstCat.PrintWeight();

            Console.WriteLine("---------------------------");

            Cat mySecondCat = new Cat("Pulla", 3);
            mySecondCat.PrintWeight();

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
