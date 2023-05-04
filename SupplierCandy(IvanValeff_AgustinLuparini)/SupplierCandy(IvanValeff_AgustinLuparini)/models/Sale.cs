using SupplierCandy_IvanValeff_AgustinLuparini_.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierCandy_IvanValeff_AgustinLuparini_.models
{
    public class Sale
    {
        public List<SaleXSweets> SaleXSweets { get; set; }
        public Client Client { get; set; }
        public Employee Employee { get; set; }

    }
}
