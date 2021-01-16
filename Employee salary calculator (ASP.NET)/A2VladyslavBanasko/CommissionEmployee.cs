using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2VladyslavBanasko
{
    class CommissionEmployee : Employee
    {

        public override double GrossSales { get; protected set; }

        public override double CommissionRate { get; protected set; }

        public CommissionEmployee(string name, EmployeeType typeOfEmp, double grossSales, double commissionRate) : base(name, typeOfEmp)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public override double GrossEarnings { get { return (CommissionRate/100) * GrossSales; } }
    }
}
