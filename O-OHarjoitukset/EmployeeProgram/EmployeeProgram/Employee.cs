using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeProgram
{
    class Employee
    {
        public string name;
        public int id;
        public string position ;
        public double salary;
        private static int counter = 1;

        public Employee(string name, int id, string position, double salary)
        {
            this.name = name;
            this.id = counter++; ;
            this.position = position;
            this.salary = salary;
        }

        public void PrintEmployeeInfo(string name, string id, string position, double salary)
        {
            Console.WriteLine($"Työntekijä: {this.name}\nId: {this.id}\nTyötehtävä: {this.position}\nPalkka: {this.salary}€");
            Console.WriteLine("-------------------------");
        }
        
        public void CompareSalary(Employee firstEmployee, Employee secondEmployee)
        {
            if(this.salary > firstEmployee.salary && firstEmployee.salary > secondEmployee.salary)
            {
                Console.WriteLine($"{this.name} saa enemmän palkkaa kuin {firstEmployee.name} ja {firstEmployee.name} saa enemmän kuin {secondEmployee.name}.");
            }
            else if (this.salary < firstEmployee.salary && firstEmployee.salary > secondEmployee.salary && this.salary < secondEmployee.salary)
            {
                Console.WriteLine($"{firstEmployee.name} saa enemmän palkkaa kuin {secondEmployee.name} ja {secondEmployee.name} saa enemmän kuin {this.name}.");
            }
            else if (this.salary < firstEmployee.salary && firstEmployee.salary > secondEmployee.salary && this.salary > secondEmployee.salary)
            {
                Console.WriteLine($"{firstEmployee.name} saa enemmän palkkaa kuin {this.name} ja {this.name} saa enemmän kuin {secondEmployee.name}.");
            }
            else if (this.salary > firstEmployee.salary && firstEmployee.salary < secondEmployee.salary && this.salary > secondEmployee.salary)
            {
                Console.WriteLine($"{firstEmployee.name} saa enemmän palkkaa kuin {this.name} ja {this.name} saa enemmän kuin {secondEmployee.name}.");
            }
            else if (this.salary > firstEmployee.salary && firstEmployee.salary < secondEmployee.salary && this.salary < secondEmployee.salary)
            {
                Console.WriteLine($"{secondEmployee.name} saa enemmän palkkaa kuin {this.name} ja {this.name} saa enemmän kuin {firstEmployee.name}.");
            }
            else if (this.salary < firstEmployee.salary && firstEmployee.salary < secondEmployee.salary && this.salary < secondEmployee.salary)
            {
                Console.WriteLine($"{secondEmployee.name} saa enemmän palkkaa kuin {firstEmployee.name} ja {firstEmployee.name} saa enemmän kuin {this.name}.");
            }
        }
        public override string ToString()
        {
            return $"Nimi: {this.name}\nId: {this.id}\nTyötehtävä: {this.position}\nPalkka: {this.salary} €\n-----------------------";
        }
    }
}
