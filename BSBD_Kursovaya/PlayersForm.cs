using BSBD_Kursovaya.Roles;
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
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником данных

            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void playerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.championshipDataSet);

        }

        private void playerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.playerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.championshipDataSet);

        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Line_Avia". При необходимости она может быть перемещена или удалена.
            this.playerTableAdapter.Fill(this.championshipDataSet.Player);
            this.regulationTableAdapter.Fill(this.championshipDataSet.Regulation);
            dataGridViewWithRes.Hide();
            if(MyRoles.currentRole!= "Участники")
            {
                dataGridViewPlayers.DataSource = FillDataGridView(@"Select Name_Player as 'Имя участника', 
Passport_Data as 'Паспортные данные участника' from Player");
            }   
            else
            {
                dataGridViewPlayers.DataSource = FillDataGridView(@"Select Name_Player as 'Имя участника' from Player");
            }
            
        }

        private void playerBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.playerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.championshipDataSet);

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewWithRes.DataSource = FillDataGridView(@"Select ID_Player as '№', Regulation_Number as 'Номер положения', Final_Place as 'Итоговое место', Start_Number as 'Стартовый номер', Result as 'Результат' from Total");
            dataGridViewWithRes.Show();
        }

        private void CheckName_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckName.Checked == true)
            {
                if (textBoxSearchName.Text == "")
                {
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    dataGridViewWithRes.DataSource = FillDataGridView($@"Select Start_Number as 'Стартовый 
номер', Final_Place as 'Итоговое место', Result as 'Результат', 
Name_Player as 'Имя спортсмена', 
Regulation_Name as 'Название соревнования' from Total, Player, Regulation 
where Total.ID_Player = Player.ID_Player and Player.Name_Player = '{textBoxSearchName.Text}'");
                    dataGridViewWithRes.Show();
                }
            }
        }
    }
}
