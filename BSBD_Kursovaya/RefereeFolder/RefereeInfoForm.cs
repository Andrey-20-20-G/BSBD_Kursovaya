using BSBD_Kursovaya.RefereeFolder;
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
    public partial class RefereeInfoForm : Form
    {
        public RefereeInfoForm()
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

        private void RefereeInfoForm_Load(object sender, EventArgs e)
        {
            dataGridViewInfo.DataSource = FillDataGridView(@"Select Total.ID_Player as 'ID участника', Name_Player as 
'Имя участника', Passport_Data as 'Паспортные данные',
Start_Number as 'Стартовый номер', Final_Place as 'Итоговое место', Result as 'Результат', 
Regulation_Name as 'Название соревнования', Total.Regulation_Number as 'Номер положения'
from Player, Regulation, Total where Total.ID_Player = Player.ID_Player");
           
        }

        private void dataGridViewTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if(radioButtonPlayer.Checked == true)
            {
                if (String.IsNullOrEmpty(textBoxName.Text) ||
           (String.IsNullOrEmpty(textBoxPass.Text) ||
           (String.IsNullOrEmpty(textBoxID.Text))))
                {
                    MessageBox.Show("Обязательно введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxID.Text, out _))
                {
                    MessageBox.Show("Некоректное значение ID!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (String.IsNullOrEmpty(textBoxName.Text))
                {
                    MessageBox.Show("Некоректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (String.IsNullOrEmpty(textBoxPass.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand($@"INSERT INTO [Player] (ID_Player, Name_Player, Passport_Data) VALUES (@ID_Player, @Name_Player, @Passport_Data)", connection);


                command.Parameters.AddWithValue("ID_Player", textBoxID.Text);
                command.Parameters.AddWithValue("Name_Player", textBoxName.Text);
                command.Parameters.AddWithValue("Passport_Data", textBoxPass.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по добавлению выполнена");
                connection.Close();

                dataGridViewInfo.DataSource = FillDataGridView(@"Select Total.ID_Player as 'ID участника', Name_Player as 
'Имя участника', Passport_Data as 'Паспортные данные',
Start_Number as 'Стартовый номер', Final_Place as 'Итоговое место', Result as 'Результат', 
Regulation_Name as 'Название соревнования', Total.Regulation_Number as 'Номер положения'
from Player, Regulation, Total where Total.ID_Player = Player.ID_Player");

                
            }
            if (radioButtonres.Checked == true)
            {
                if (String.IsNullOrEmpty(textBoxID.Text) ||
           (String.IsNullOrEmpty(textBoxRegNum.Text) || 
           (String.IsNullOrEmpty(textBoxStart.Text) || 
           (String.IsNullOrEmpty(textBoxRes.Text) ||
           (String.IsNullOrEmpty(textBoxTotalPlace.Text))))))
                {
                    MessageBox.Show("Обязательно введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxID.Text, out _))
                {
                    MessageBox.Show("Некоректное значение ID!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(textBoxRegNum.Text, out _))
                {
                    MessageBox.Show("Некоректное значение номера положения!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                

                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand($@"INSERT INTO [Total] (ID_Player, Regulation_Number, Result, Start_Number, Final_Place) VALUES (@ID_Player, @Regulation_Number, @Result, @Start_Number, @Final_Place)", connection);


                command.Parameters.AddWithValue("ID_Player", textBoxID.Text);
                command.Parameters.AddWithValue("Regulation_Number", textBoxRegNum.Text);
                command.Parameters.AddWithValue("Result", textBoxRes.Text);
                command.Parameters.AddWithValue("Start_Number", textBoxStart.Text);
                command.Parameters.AddWithValue("Final_Place", textBoxTotalPlace.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по добавлению выполнена");
                connection.Close();

                dataGridViewInfo.DataSource = FillDataGridView(@"Select Total.ID_Player as 'ID участника', Name_Player as 
'Имя участника', Passport_Data as 'Паспортные данные',
Start_Number as 'Стартовый номер', Final_Place as 'Итоговое место', Result as 'Результат', 
Regulation_Name as 'Название соревнования', Total.Regulation_Number as 'Номер положения'
from Player, Regulation, Total where Total.ID_Player = Player.ID_Player");

                
            }
            if(radioButtonres.Checked == false && radioButtonPlayer.Checked == false)
            {
                MessageBox.Show("Выберите таблицу с которой вы хотите произвести действие!!!");
            }
            radioButtonPlayer.Checked = false;
            radioButtonres.Checked = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            #region Delete Player
            if (radioButtonPlayer.Checked == true)
            {
                if (String.IsNullOrEmpty(textBoxID.Text))
                {
                    MessageBox.Show("Обязательно введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxID.Text, out _))
                {
                    MessageBox.Show("Некоректное значение ID участника!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand($@"DELETE FROM Player WHERE  ID_Player = @ID_Player", connection);

                command.Parameters.AddWithValue("ID_Player", textBoxID.Text);

                MessageBox.Show(command.ExecuteNonQuery().ToString() + " команда по удалению выполнена");
                connection.Close();
                


                dataGridViewInfo.DataSource = FillDataGridView(@"Select Total.ID_Player as 'ID участника', Name_Player as 
'Имя участника', Passport_Data as 'Паспортные данные',
Start_Number as 'Стартовый номер', Final_Place as 'Итоговое место', Result as 'Результат', 
Regulation_Name as 'Название соревнования', Total.Regulation_Number as 'Номер положения'
from Player, Regulation, Total where Total.ID_Player = Player.ID_Player");
            }
            #endregion

            if (radioButtonres.Checked == true)
            {
                if (String.IsNullOrEmpty(textBoxID.Text))
                {
                    MessageBox.Show("Обязательно введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxID.Text, out _))
                {
                    MessageBox.Show("Некоректное значение ID участника!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (String.IsNullOrEmpty(textBoxRegNum.Text))
                {
                    MessageBox.Show("Обязательно введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxRegNum.Text, out _))
                {
                    MessageBox.Show("Некоректное значение номера положения!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand($@"DELETE FROM Total WHERE  ID_Player = @ID_Player and @Regulation_Number = Regulation_Number", connection);

                command.Parameters.AddWithValue("ID_Player", textBoxID.Text);
                command.Parameters.AddWithValue("Regulation_Number", textBoxRegNum.Text);

                MessageBox.Show(command.ExecuteNonQuery().ToString() + " команда по удалению выполнена");
                connection.Close();



                dataGridViewInfo.DataSource = FillDataGridView(@"Select Total.ID_Player as 'ID участника', Name_Player as 
'Имя участника', Passport_Data as 'Паспортные данные',
Start_Number as 'Стартовый номер', Final_Place as 'Итоговое место', Result as 'Результат', 
Regulation_Name as 'Название соревнования', Total.Regulation_Number as 'Номер положения'
from Player, Regulation, Total where Total.ID_Player = Player.ID_Player");
            }
            if (radioButtonres.Checked == false && radioButtonPlayer.Checked == false)
            {
                MessageBox.Show("Выберите таблицу с которой вы хотите произвести действие!!!");
            }
            radioButtonPlayer.Checked = false;
            radioButtonres.Checked = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (radioButtonPlayer.Checked == true)
            {
                if (String.IsNullOrEmpty(textBoxName.Text) ||
           (String.IsNullOrEmpty(textBoxPass.Text) ||
           (String.IsNullOrEmpty(textBoxID.Text))))
                {
                    MessageBox.Show("Обязательно введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxID.Text, out _))
                {
                    MessageBox.Show("Некоректное значение ID!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (String.IsNullOrEmpty(textBoxName.Text))
                {
                    MessageBox.Show("Некоректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (String.IsNullOrEmpty(textBoxPass.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand($@"UPDATE Player SET ID_Player = @ID_Player, Name_Player = @Name_Player, Passport_Data = @Passport_Data WHERE ID_Player = @ID_Player", connection);


                command.Parameters.AddWithValue("ID_Player", textBoxID.Text);
                command.Parameters.AddWithValue("Name_Player", textBoxName.Text);
                command.Parameters.AddWithValue("Passport_Data", textBoxPass.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по изменению выполнена");
                connection.Close();

                dataGridViewInfo.DataSource = FillDataGridView(@"Select Total.ID_Player as 'ID участника', Name_Player as 
'Имя участника', Passport_Data as 'Паспортные данные',
Start_Number as 'Стартовый номер', Final_Place as 'Итоговое место', Result as 'Результат', 
Regulation_Name as 'Название соревнования', Total.Regulation_Number as 'Номер положения'
from Player, Regulation, Total where Total.ID_Player = Player.ID_Player");


            }
            if (radioButtonres.Checked == true)
            {
                if (String.IsNullOrEmpty(textBoxID.Text) ||
           (String.IsNullOrEmpty(textBoxRegNum.Text) ||
           (String.IsNullOrEmpty(textBoxStart.Text) ||
           (String.IsNullOrEmpty(textBoxRes.Text) ||
           (String.IsNullOrEmpty(textBoxTotalPlace.Text))))))
                {
                    MessageBox.Show("Обязательно введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxID.Text, out _))
                {
                    MessageBox.Show("Некоректное значение ID!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(textBoxRegNum.Text, out _))
                {
                    MessageBox.Show("Некоректное значение номера положения!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand($@"UPDATE Total SET ID_Player = @ID_Player, 
Regulation_Number = @Regulation_Number, Result = @Result, Start_Number = @Start_Number, 
Final_Place = @Final_Place WHERE ID_Player = 
@ID_Player and Regulation_Number = @Regulation_Number", connection);


                command.Parameters.AddWithValue("ID_Player", textBoxID.Text);
                command.Parameters.AddWithValue("Regulation_Number", textBoxRegNum.Text);
                command.Parameters.AddWithValue("Result", textBoxRes.Text);
                command.Parameters.AddWithValue("Start_Number", textBoxStart.Text);
                command.Parameters.AddWithValue("Final_Place", textBoxTotalPlace.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по изменению выполнена");
                connection.Close();

                dataGridViewInfo.DataSource = FillDataGridView(@"Select Total.ID_Player as 'ID участника', Name_Player as 
'Имя участника', Passport_Data as 'Паспортные данные',
Start_Number as 'Стартовый номер', Final_Place as 'Итоговое место', Result as 'Результат', 
Regulation_Name as 'Название соревнования', Total.Regulation_Number as 'Номер положения'
from Player, Regulation, Total where Total.ID_Player = Player.ID_Player");


            }
            if (radioButtonres.Checked == false && radioButtonPlayer.Checked == false)
            {
                MessageBox.Show("Выберите таблицу с которой вы хотите произвести действие!!!");
            }
            radioButtonPlayer.Checked = false;
            radioButtonres.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerData pd = new PlayerData();
            pd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TotalData td = new TotalData();
            td.Show();
        }
    }
}
