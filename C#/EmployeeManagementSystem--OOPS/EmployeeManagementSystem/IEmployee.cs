﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public interface IEmployee<Employee> 
    {
        string PrintEmployeeDetails(Employee employee);
    }
}
