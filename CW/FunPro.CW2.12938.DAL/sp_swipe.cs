using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW2.DAL
{
    public class sp_swipe
    {
        //as for em_employee class, we use private DateTime for setting Exception in certain cases
        private DateTime SpOut;

        public int Id { get; set; }
        //EmployeeId is correlated with Id of em_employee table of our database. For linking it we will set a em_employee class with property name of EmployeeId
        public em_employee EmployeeId { get; set; }

        public DateTime Date { get; set; }

        public DateTime In { get; set; }

        public DateTime Out { get => SpOut; set
            {
                if(In > value)
                {
                    //it is not possible to have swipe out earlier than swipe in. For set we set an exception
                    throw new Exception("Swipe for out can not be earlier for swipe in");
                }
                SpOut = value;
            }
        }
        //initial constructor
        public sp_swipe()
        {

        }

        public sp_swipe(em_employee employeeId, DateTime date, DateTime @in, DateTime @out)
        {
            EmployeeId = employeeId;
            Date = date;
            In = @in;
            Out = @out;
        }
    }
}
