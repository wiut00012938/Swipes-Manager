using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace FunPro.CW2._12938.DAL
{
    public class dbManager
    {
        public SQLiteConnection Connection
        {
            // in our Connection we only get, not setting data
            get
            {
                return new SQLiteConnection(Properties.Settings.Default.ConnectionString); //in a setting our db  was specified by name ConnectionString
            }
        }
    }
}
