using FunPro.CW2.DAL;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPro.CW2._12938.DAL
{
    public class sp_swipe_manager :dbManager
    {
        //the same codes as in em_employee_manager()
        public void Create(sp_swipe c)
        {
            var connection = Connection;
            try
            {
                var sql = $"INSERT INTO sp_swipe (sp_emp_id_12938,sp_date_12938,sp_in_12938,sp_out_12938) VALUES ('{c.EmployeeId.Id}','{c.Date.Ticks}','{c.In.Ticks}','{c.Out.Ticks}')";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        public sp_swipe GetByEmployeeId(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
SELECT sp_id_12938,
sp_emp_id_12938,
sp_date_12938,
sp_in_12938,
sp_out_12938
FROM sp_swipe
WHERE sp_emp_id_12938 = {id}"; //we are filtering by employee id, not swipe id
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                    if (reader.Read())
                {
                    return new sp_swipe
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        EmployeeId = new em_employee_manager().GetById(Convert.ToInt32(reader.GetValue(1))),
                        Date = new DateTime(Convert.ToInt64(reader.GetValue(2))),
                        In = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        Out = new DateTime(Convert.ToInt64(reader.GetValue(4)))
                    };
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

            // if we are here - something went wrong
            return null;
        }

        public List<sp_swipe> GetAll()
        {
            var allEmployees = new em_employee_manager().GetAll().ToDictionary(t => t.Id, t => t);//generally used for optimization as every time we do the same job for each row and with that we have the worest scenario
            var connection = Connection;
            var result = new List<sp_swipe>();
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
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        var a = new sp_swipe
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


        public sp_swipe GetSwipeDates(int id,long starting_point,long ending_point) //another method that is used for validation of new swipe
        {
            var connection = Connection;
            try
            {
                var sql = $@"
SELECT
sp_date_12938
FROM sp_swipe
WHERE sp_emp_id_12938 = {id} and sp_date_12938 BETWEEN {starting_point} AND {ending_point}"; //because we use ticks that also takes time, we can have a case tha even if input dates are the same(dd.MM), it will skip that as with the time(HH:MM) number of Ticks are not equal
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using (var reader = command.ExecuteReader()) //using was included because of the issue "Database is locked"
                    if (reader.Read())
                    {
                        return new sp_swipe
                        {
                            Date = new DateTime(Convert.ToInt64(reader.GetValue(0)))
                        };
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

            // if we are here - something went wrong
            return null;
        }

    }
}
