using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierCandy_IvanValeff_AgustinLuparini_.interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        string LastName { get; set; }
        string Dni { get; set; }
        string Phone { get; set; }
    }
}
