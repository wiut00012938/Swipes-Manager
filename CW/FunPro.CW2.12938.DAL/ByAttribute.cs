using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW2._12938.DAL
{
    //By Attribute is needed to create a enumaration for selected items. If for instance we want to change Name to EmployeeName, we can substitute Name here and will not worry about replacement in other classes
    public enum ByAttribute
    {
        Name,
        IsActive,
        IsNotActive,
        BothActive,
        StartDate,
        DischargeDate
    }
}
