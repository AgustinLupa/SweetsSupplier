using SupplierCandy_IvanValeff_AgustinLuparini_.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierCandy_IvanValeff_AgustinLuparini_.interfaces
{
    public interface ISalaryCalculator
    {
        public double Salary(Employee employee);
    }
}
