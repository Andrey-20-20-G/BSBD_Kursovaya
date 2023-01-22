using BSBD_Kursovaya.DB_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBD_Kursovaya.Roles
{
   
    internal class MyRoles
    {

        public static string currentRole;
        
        public void GetRole(string login, string pass)
        {
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-T22HF5E5; Initial Catalog = Authorization; Integrated Security = True;App=Agent;Asynchronous Processing=true"))
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                string check2 = $"select UserRole from Sign_on_table where Login = '{login}' and Password = '{pass}'";
                SqlCommand cmd2 = new SqlCommand(check2, sqlConnection);
                string role = (string)cmd2.ExecuteScalar();
                currentRole = role;
            }
            
        }   
    }  
}
