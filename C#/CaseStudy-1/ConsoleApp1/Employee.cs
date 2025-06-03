using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public string Name { get; set; }
    }
    class Manager : Employee { }
    class Developer : Employee { }
    class Intern : Employee { }


    class Program
    {
        static void PrintEmployeeRole(Employee emp)
        {
            if (emp is Manager)
            {
                Console.WriteLine($"{emp.Name} is a Manager.");
            }
            else if (emp is Developer)
            {
                Console.WriteLine($"{emp.Name} is a Developer.");
            }
            else if (emp is Intern)
            {
                Console.WriteLine($"{emp.Name} is an Intern.");
            }
            else
            {
                Console.WriteLine($"{emp.Name} has an unknown role.");
            }
        }

        static void Main(string[] args)
        {
            Employee emp1 = new Manager { Name = "Alice" };
            Employee emp2 = new Developer { Name = "Bob" };
            Employee emp3 = new Intern { Name = "Charlie" };

            PrintEmployeeRole(emp1);
            PrintEmployeeRole(emp2);
            PrintEmployeeRole(emp3);
        }
    }
}
