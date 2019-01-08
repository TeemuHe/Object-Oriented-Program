using System;

namespace CatProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a cat program");

            Cat myFirstCat = new Cat("Pilli",1);
            //myFirstCat.weight = 5;
            //Console.WriteLine($"Cats weight is changed {myFirstCat.weight}");

            Cat mySecondCat = new Cat("Pulla", 3);

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
