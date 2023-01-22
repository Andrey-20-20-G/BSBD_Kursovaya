using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BSBD_Kursovaya.DB_Model
{
    internal class ConnectWithMSSQL
    {
        //public async Task<System.Data.ConnectionState> ConnectWithMSSQLAsync()
        //{
        //    string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        await connection.OpenAsync();
        //        return connection.State;
        //        Thread.Sleep(5000);
        //        //Console.WriteLine("Подключение открыто");
        //    }
        //    //Console.WriteLine("Подключение закрыто...");
        //    //Console.WriteLine("Программа завершила работу.");

        //}
        //string connectionString = @"Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-T22HF5E5; Initial Catalog = Authorization; Integrated Security = True;App=Agent;Asynchronous Processing=true");

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
