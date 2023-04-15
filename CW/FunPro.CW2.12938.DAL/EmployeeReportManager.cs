using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunPro.CW2.DAL;

namespace FunPro.CW2._12938.DAL
{
    public class EmployeeReportManager:dbManager
    {
        // similar code from em_employee_manager
        public List<EmployeeReport> GetAll()
        {
            var allEmployees = new em_employee_manager().GetAll().ToDictionary(t => t.Id, t => t);
            var connection = Connection;
            var result = new List<EmployeeReport>();
            try
            {
                var sql = $@"
SELECT sp_id_12938,
sp_emp_id_12938,
sp_date_12938,
sp_in_12938,
sp_out_12938
FROM sp_swipe";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var a = new EmployeeReport
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        EmployeeId = allEmployees[Convert.ToInt32(reader.GetValue(1))],
                        Date = new DateTime(Convert.ToInt64(reader.GetValue(2))),
                        In = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        Out = new DateTime(Convert.ToInt64(reader.GetValue(4)))
                    };
                    result.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return result;
        }
        public List<EmployeeReport> Searching(int value, DateTime searchtime)
        {
            //before finding a sum of hours worked, we need to filter the data. We need to fitter by employeeid and the month of a report
            return GetAll().Where(a => Convert.ToDateTime(a.Date).Month == searchtime.Month & Convert.ToInt32(a.EmployeeId.ToString()) == value).ToList();
        }
    }
}
