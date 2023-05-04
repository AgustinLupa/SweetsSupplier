using SupplierCandy_IvanValeff_AgustinLuparini_.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierCandy_IvanValeff_AgustinLuparini_.models
{
    public class SaleXSweets
    {
        public ISweets Sweets { get; set; }
        public double Ammount { get; set; }
    }
}
