using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBD_Kursovaya.DB_Model
{
    internal class TheSecondCon
    {
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-T22HF5E5; Initial Catalog = Championship; Integrated Security = True;App=Agent;Asynchronous Processing=true");

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        public SqlConnection SqlConnectionState()
        {
            return conn;
        }
    }
}
