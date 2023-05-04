using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierCandy_IvanValeff_AgustinLuparini_.interfaces
{
    public interface ISweets
    {
        double Price { get; set; }
        string NameMark { get; set; }
        double Weight { get; set; }
    }
}
