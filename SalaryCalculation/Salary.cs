using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SalaryCalculation
{
    class Salary
    {
        public double basicSalary;
        public double houseRentPercentage;
        public double medicalAllowancePercentage;

        public double CalculateTotalSalary()
        {
            double houseRentAmount = basicSalary * houseRentPercentage / 100;
            double medicalAllowanceAmount = basicSalary * medicalAllowancePercentage / 100;
            double totalSalary = basicSalary + houseRentAmount + medicalAllowanceAmount;

            return totalSalary;

        }

    }
}
