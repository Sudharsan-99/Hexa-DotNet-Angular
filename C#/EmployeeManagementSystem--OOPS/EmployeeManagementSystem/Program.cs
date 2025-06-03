using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Program
    {
        public static void Main()
        {
            // Part-Time Employee
            PartTimeEmployee pte = new PartTimeEmployee
            {
                EmpCode = 100,
                EmpName = "Sonu",
                Email = "sonu@gmail.com",
                DeptName = "Full Stack",
                Location = "Pune",
                Basic = 10000
            };
            pte.CalculateSalary();
            Console.WriteLine($"{pte.EmpCode}\t{pte.EmpName}\t{pte.Email}\t{pte.DeptName}\t{pte.Location}");
            Console.WriteLine($"Net Salary For Part Time Employee is:{(int)pte.NetSalary}");
            Console.WriteLine();

            // Full-Time Employee
            FullTimeEmployee fte = new FullTimeEmployee
            {
                EmpCode = 101,
                EmpName = "Sudharsan",
                Email = "sudharsan@gmail.com",
                DeptName = "Hr",
                Location = "Pune",
                Basic = 20000
            };
            fte.CalculateSalary();
            Console.WriteLine($"{fte.EmpCode}\t{fte.EmpName}\t{fte.Email}\t{fte.DeptName}\t{fte.Location}");
            Console.WriteLine($"Net Salary For Full Time Employee is:{(int)fte.NetSalary}");

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }

}
