using FunPro.CW2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW2._12938.DAL
{
    partial class em_employee_manager // for making our employee manager less messy separation can be used. Class name is the same, but now is it partial
    {
        public List<em_employee> SortLinq(ByAttribute attribute)
        {
            switch(attribute)
                {
                case ByAttribute.Name:
                    return GetAll().OrderBy(a => a.Name).ToList(); //Sorting By Name could be enough, but anyways it just gives more options
                case ByAttribute.StartDate:
                    return GetAll().OrderBy(a => a.StartDate).ToList();
                case ByAttribute.DischargeDate:
                    return GetAll().OrderBy(a => a.DischargeDate).ToList();

            }
            return null;
        }

        public List<em_employee> Filtering(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.IsActive:
                    return GetAll().Where(a => a.IsActive == true).ToList();//WHERE() is used for specifying details of filtering
                case ByAttribute.IsNotActive:
                    return GetAll().Where(a => a.IsActive == false).ToList();//Not Active means false in terms of boolean(in the database it is stored as 0)
                case ByAttribute.BothActive:
                    return GetAll().Where(a => a.IsActive == true | a.IsActive == false).ToList();
            }
            //if we are here - something went wrong
            return null;
        }

    }
}
