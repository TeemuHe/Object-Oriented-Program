using System;
using System.Collections.Generic;
using System.Text;

namespace CatProgram
{
    class Cat
    {
        public string name;

        public int weight;

        public Cat()
        {
            this.weight = 1;
            //Console.WriteLine($"Cats start weight is {this.weight}");
        }

        public Cat(string name, int weightValue)
        {
            this.name = name;
            this.weight = weightValue;
            Console.WriteLine($"Created cat {this.name}");
        }

        public Cat(int weightValue)
        {
            this.weight = weightValue;
            //Console.WriteLine($"Cats weight is {this.weight}");
        }

        public void printWeight()
        {
            Console.WriteLine($"Cats weight is {this.weight}");
        }
    }
}
