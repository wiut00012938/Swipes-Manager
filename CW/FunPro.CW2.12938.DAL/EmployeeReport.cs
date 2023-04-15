using FunPro.CW2.DAL;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FunPro.CW2._12938.DAL
{
    //for monthly calculations or in other words Report form we need to use another class with properties because we have more properties as RoudedIn, RoundedOut..
    public class EmployeeReport
    {
        //external properties for validation
        public DateTime Rounded_In;
        public DateTime Rounded_Out;
        public double Difference;


        public int Id { get; set; }
        public em_employee EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime In { get; set; }
        public DateTime Out { get; set; }
        public DateTime RoundedIn
        {
            get
            {
                //we need to look for times that are earlier than 9 and rounded them to 9:00
                if (Convert.ToInt32(In.ToString("HH")) < 9)
                {
                    Rounded_In = new DateTime(Out.Year, Out.Month, Out.Day, 9, 0, 0);
                    return Rounded_In;
                }
                else
                {
                    return Rounded_In = In;
                }
            }
            set
            {
                Rounded_In = value;
            }
        }
        public DateTime RoundedOut {
            get{
                //similar to RoudedIn, but now we need to round hours than are more than 18:00
                if (Convert.ToInt32(Out.ToString("HH")) > 17)
                {
                    RoundedOut = new DateTime(Out.Year, Out.Month, Out.Day, 18, 0, 0);
                    return Rounded_Out;
                }
                else
                {
                    return Rounded_Out = Out;
                }
            }
            set
            {
                Rounded_Out = value;
            }
        }
        public double HoursWorked {
            get
            {
                //Timespan is perfect for datetime calculations
                TimeSpan difference = RoundedOut - RoundedIn;
                Difference = Math.Round(difference.TotalHours,2);
                return Difference;
            }
            set
            {
                Difference = value;
            }
        }



        //our favourite constructor
        public EmployeeReport()
        {

        }
        public EmployeeReport(int id, em_employee employeeId,DateTime date, DateTime @in, DateTime @out, DateTime roundedIn, DateTime roundedOut, double hoursWorked)
        {
            Id = id;
            EmployeeId = employeeId;
            Date = date;
            In = @in;
            Out = @out;
            RoundedIn = roundedIn;
            RoundedOut = roundedOut;
            HoursWorked = hoursWorked;
        }

    }
}
