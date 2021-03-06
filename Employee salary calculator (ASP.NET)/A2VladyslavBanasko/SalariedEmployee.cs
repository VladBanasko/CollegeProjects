﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2VladyslavBanasko
{
   public class SalariedEmployee : Employee
    {
        public double Salary { get; private set; }

        public SalariedEmployee(string name, EmployeeType type, double salary) : base(name, type)
        {
            Salary = salary;
        }

        public override double GrossEarnings { get { return Salary; } }
    }
}
