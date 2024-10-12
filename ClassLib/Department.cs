﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        public int EmployeeAmount { get; set; }

        public void UpdateEmployeeAmount()
        {
            EmployeeAmount = Employees.Count/2;
        }
    }
}
