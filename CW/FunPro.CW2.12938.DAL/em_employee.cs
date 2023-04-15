using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FunPro.CW2.DAL
{
    /*Initionation of employee class where we will state the properties of a class. Each property will be related to table from database(em_employee table)*/
    public class em_employee
    {
        //these privated properies are needed for working with exeption management inside get set
        private string name;
        private DateTime Discharge_Date;

        public int Id { get; set; }

        public string Name
        {
            get => name; 
            set
            {
                /*We must not allow to set a value that is null or when some stupid people enter spaces*/
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty");
                name = value;
            }
        }

        public bool IsActive { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DischargeDate {
            get => Discharge_Date;
            set
            {
                /*We must not allow to set a value that is earlier than a start date of employee as it doesn't make a sense*/
                if (StartDate > value)
                {
                    throw new Exception("Discharge Date can not be earlier than a start date");
                }
                Discharge_Date = value; 
            }
        }

        
        public em_employee()
        {
            /*who is calling em_employee, the default value for em_discharge_date will be 01/01/2050, if this property was not specified*/
            DischargeDate = new DateTime(2050,01,01);

        }
        /* complete constructor that will be used for interaction with database soon*/
        public em_employee(string name, bool isActive, DateTime startDate, DateTime dischargeDate)
        {
            Name = name;
            IsActive = isActive;
            StartDate = startDate;
            DischargeDate = dischargeDate;
        }
        /* override is used for data Grid View for specific which specific column to return*/
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
