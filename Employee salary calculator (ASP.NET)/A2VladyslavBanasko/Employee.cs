using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2VladyslavBanasko
{
    public enum EmployeeType
    {
        Hourly_Rate, Commision_Based, Weekly_Salary
    }
    public abstract class Employee
    {


        public string Name { get; private set; }

        public EmployeeType TypeOfEmployee { get; private set; }

        public Employee(string name, EmployeeType type) {

            Name = name;
            TypeOfEmployee = type;
        }


        public abstract double GrossEarnings { get; }
        public double Tax { get { return GrossEarnings * 0.2; } }
        public double NetEarnings { get { return GrossEarnings - Tax; } }

        public virtual int HoursWorked { get; protected set; }

        public virtual double HourlyWage { get; protected set; }

        public virtual double GrossSales { get; protected set; }

        public virtual double CommissionRate { get; protected set; }


    }
}
