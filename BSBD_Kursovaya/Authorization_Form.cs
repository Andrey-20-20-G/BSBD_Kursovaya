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
using BSBD_Kursovaya.DB_Model;
using BSBD_Kursovaya.Roles;

namespace BSBD_Kursovaya
{
    public partial class Authorization_Form : Form
    {
        public Authorization_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Password_text.PasswordChar = '*';
            Login_textbox.MaxLength = 40;
            Password_text.MaxLength = 32;
        }

        private void Authorization_button_Click(object sender, EventArgs e)
        {
            var login = Login_textbox.Text;
            var pass = Password_text.Text;
            var con = new ConnectWithMSSQL();
            //var mycon = await con.ConnectWithMSSQLAsync();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string check = $"select Login, Password from Sign_on_table where Login = '{login}' and Password = '{pass}'";
            
            SqlCommand cmd = new SqlCommand(check, con.SqlConnectionState());
            
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
               
                MyRoles user = new MyRoles();
                user.GetRole(login, pass);
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                Application.Exit();
                

            }
            else
                MessageBox.Show("NT");
        }

        private void Registration_label_Click(object sender, EventArgs e)
        {
            Registration_Form registration_Form = new Registration_Form();
            this.Hide();
            registration_Form.ShowDialog();
            Application.Exit();
        }
    }
}
