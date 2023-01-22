using BSBD_Kursovaya.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD_Kursovaya
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //MyRoles curRole = new MyRoles();
        private void HR_Click(object sender, EventArgs e)
        {
            if (MyRoles.currentRole == "Администраторы")
            {
                HRForm hrForm = new HRForm();
                this.Hide();
                hrForm.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав для доступа");
            }
        }

        private void PlayersInfo_Click(object sender, EventArgs e)
        {
            
            PlayersForm playersForm = new PlayersForm();
            this.Hide();
            playersForm.ShowDialog();
            Application.Exit();
        }

        private void RefereeInfo_Click(object sender, EventArgs e)
        {
            if (MyRoles.currentRole == "Судья" || MyRoles.currentRole == "Администраторы")
            {
                RefereeInfoForm refereeinfoForm = new RefereeInfoForm();
                this.Hide();
                refereeinfoForm.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав для доступа");
            }
        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            Authorization_Form authForm = new Authorization_Form();
            this.Hide();
            authForm.ShowDialog();
            
        }
    }
}
