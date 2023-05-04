using SupplierCandy_IvanValeff_AgustinLuparini_.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierCandy_IvanValeff_AgustinLuparini_.models
{
    public class Employee : IPerson
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public double HoursWorking { get; set; }
        public double PriceForHour { get; set; }

       
    }

}
