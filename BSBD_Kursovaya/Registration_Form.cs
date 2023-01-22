using BSBD_Kursovaya.DB_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD_Kursovaya
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {
            Password_text.PasswordChar = '*';
            Login_text.MaxLength = 40;
            Password_text.MaxLength = 32;
            Repeat_Password.PasswordChar = '*';
            Repeat_Password.MaxLength = 32;
        }

        private void Sign_on_Click(object sender, EventArgs e)
        {
            ConnectWithMSSQL connectWithMSSQL = new ConnectWithMSSQL();
            var login = Login_text.Text;
            var pass = Password_text.Text;
            var rep = Repeat_Password.Text;
            if(pass.Length < 4 || rep.Length < 4)
            {
                MessageBox.Show("Минимальная длина пароля 4 символа! Попробуйте ввести данные еще раз");
            }
            else
            { 
            string check = "";
            SqlCommand sqlCommand = null;
            if (pass == rep)
            {
                if (checkuser() == false)
                {
                    check = $"insert into Sign_on_table(Login, Password) values ('{login}', '{pass}')";
                    sqlCommand = new SqlCommand(check, connectWithMSSQL.SqlConnectionState());
                
                connectWithMSSQL.openConnection();
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан");
                    Authorization_Form authForm = new Authorization_Form();
                    this.Hide();
                    authForm.ShowDialog();
                    Application.Exit();
                }
                else
                    MessageBox.Show("Error");
                connectWithMSSQL.closeConnection();
                }
                else
                {
                    MessageBox.Show("Это имя уже занято. Попробуйте другой логин!");
                }
            }
            else MessageBox.Show("Введенные пароли не совпадают");
            }

        }

        private bool checkuser()
        {
            var login = Login_text.Text;
            var pass = Password_text.Text;
            var con = new ConnectWithMSSQL();
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string check = $"select Login from Sign_on_table where Login = '{login}'";
            SqlCommand cmd = new SqlCommand(check, con.SqlConnectionState());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            { 
                return true;

            }
            else
                return false;
        }
    }
}
