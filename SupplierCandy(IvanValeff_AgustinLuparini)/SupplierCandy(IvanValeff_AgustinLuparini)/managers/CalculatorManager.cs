using SupplierCandy_IvanValeff_AgustinLuparini_.interfaces;
using SupplierCandy_IvanValeff_AgustinLuparini_.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierCandy_IvanValeff_AgustinLuparini_.managers
{
    public class CalculatorManager : ISweetsCalculator, ISalaryCalculator
    {
        public double PriceCalculator(double price, double ammount)
        {
            return price * ammount;
        }

        public double Salary(Employee employee)
        {
            return employee.HoursWorking * employee.PriceForHour;
        }
    }
}
