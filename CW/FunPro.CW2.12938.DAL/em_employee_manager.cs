using FunPro.CW2.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPro.CW2._12938.DAL
{
    public partial class em_employee_manager : dbManager //by entering : dbManager we are referencing it as it manages our database
    {
        public void Create(em_employee c)
        {
            var connection = Connection; // Connection is a part of dbManager. It reference to our real database connection
            try //in every void, list we will use try-catch method
            {
                var sql = $"INSERT INTO em_employee (em_name_12938,em_is_active_12938,em_start_date_12938,em_discharge_date_12938) VALUES ('{c.Name}','{Convert.ToInt32(c.IsActive)}','{c.StartDate.Ticks}','{c.DischargeDate.Ticks}')";//sqlite doesn't support datetime data type. That is why we need to convert datetime to int. We can use Ticks for that
                var command = new SQLiteCommand(sql, connection);//var sql states our queary
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)//we need to close a connection. In case if it stays open our database will be locked when creating new connection
                    connection.Close();
            }
        }
        public void Update(em_employee c)
        {
            var connection = Connection;
            try
            {
                var sql = $"UPDATE em_employee SET em_name_12938 = '{c.Name}',em_is_active_12938 = '{Convert.ToInt32(c.IsActive)}',em_start_date_12938 = '{c.StartDate.Ticks}', em_discharge_date_12938 = '{c.DischargeDate.Ticks}' WHERE em_id_12938 = {c.Id}";
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
        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"Delete from em_employee Where em_id_12938 = {id}";// for deleting specific row we only need id data
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

        public List<em_employee> GetAll()// GetAll() will gate all data, not only one row. Therefore, using list is needed
        {
            var connection = Connection;
            var result = new List<em_employee>();
            try
            {
                var sql = "SELECT em_id_12938,em_name_12938,em_is_active_12938,em_start_date_12938,em_discharge_date_12938 FROM em_employee";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                    while (reader.Read()) //loop for loading data row by row
                {
                    var c = new em_employee
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1)),
                        IsActive = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(2))),
                        StartDate = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        DischargeDate = new DateTime(Convert.ToInt64(reader.GetValue(4)))
                    };
                    result.Add(c);
                }
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

            return result;
        }
        public em_employee GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"SELECT em_id_12938,em_name_12938,em_is_active_12938,em_start_date_12938,em_discharge_date_12938 FROM em_employee Where em_id_12938 = {id}";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                    if (reader.Read())
                {
                    var c = new em_employee
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1)),
                        IsActive = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(2))),
                        StartDate= new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        DischargeDate = new DateTime(Convert.ToInt64(reader.GetValue(4)))
                    };
                    return c;
                }
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

            return null;
        }


    }
}
