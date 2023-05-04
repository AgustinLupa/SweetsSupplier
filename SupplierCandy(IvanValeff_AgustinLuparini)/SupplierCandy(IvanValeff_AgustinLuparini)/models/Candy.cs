using SupplierCandy_IvanValeff_AgustinLuparini_.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierCandy_IvanValeff_AgustinLuparini_.models
{
    public class Candy : ISweets
    {
        public double Price { get; set; }
        public string NameMark { get; set; } = string.Empty;
        public double Weight { get; set; }

        public bool Soft { get; set; }
    }
}
