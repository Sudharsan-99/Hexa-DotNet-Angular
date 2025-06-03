using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class PartTimeEmployee : Employee, IPartTimeEmployee
    {
        public double Basic { get; set; }
        public double Da { get; set; }
        public double NetSalary { get; set; }

        public double CalculateSalary()
        {
            Da = 0.05 * Basic;
            NetSalary = Basic + Da;
            return NetSalary;
        }

        public string PrintEmployeeDetails(Employee employee)
        {
            return $"[PartTime] EmpCode: {employee.EmpCode}, Name: {employee.EmpName}, Email: {employee.Email}, Dept: {employee.DeptName}, Location: {employee.Location}, NetSalary: {NetSalary}";
        }
    }

}
