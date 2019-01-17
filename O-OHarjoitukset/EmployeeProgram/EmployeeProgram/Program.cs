using System;

namespace EmployeeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Työntekijäluokka");

            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Matti", 0, "Opettaja", 2500);
            employees[1] = new Employee("Juha", 0, "Poliisi", 3000);
            employees[2] = new Employee("Hannu", 0, "Myyjä", 2000);

            for (int i = 0; i < 2; i++)
            {
                employees[i].PrintEmployeeInfo("nimi", "id", "tehtävä", 0);
            }

            employees[0].CompareSalary(employees[1],employees[2]);
        }
    }
}
