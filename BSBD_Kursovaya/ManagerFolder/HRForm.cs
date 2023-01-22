using BSBD_Kursovaya.DB_Model;
using BSBD_Kursovaya.ManagerFolder;
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
    public partial class HRForm : Form
    {
        public HRForm()
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

        //private void managerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.managerBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.championshipDataSet);

        //}

        private void HRForm_Load(object sender, EventArgs e)
        {

        }


        private void HRForm_Load_1(object sender, EventArgs e)
        {
           

        }

        private void managerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.championshipDataSet);

        }

        private void HRForm_Load_2(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "championshipDataSet.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.championshipDataSet.Manager);
            textBoxID.Hide();
            textBoxID_M.Hide();
            textBoxID_S.Hide();
            textBoxID_ref.Hide();
            
            textBoxCompany.Hide();
            textBoxStatus.Hide();
            textBoxPosition.Hide();
            textBoxPD.Hide();
            textBoxName.Hide();
            textBoxRegName.Hide();
            textBoxDate.Hide();
            textBoxCount.Hide();



        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if(radioButtonManagers.Checked)
            {
                Employee employee = new Employee();
                employee.ShowDialog();  
            }
            if(radioButtonReferee.Checked)
            {
                Employee employee = new Employee();
                employee.ShowDialog();
            }
            if (radioButtonSponsor.Checked)
            {
                Employee employee = new Employee();
                employee.ShowDialog();
                
            }
            if (radioButtonRegulation.Checked)
            {
                
                dataGridView1.DataSource = FillDataGridView(@"Select Regulation_Number as '№ положения', Date_of_Regulation as 'Дата проведения', Regulation_Name as 'Название соревнования', Count_of_Members as 'Кол-во участников', ID_Manager, ID_Sponsor, ID_Referee from Regulation");
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (radioButtonReferee.Checked)
            {
                if (String.IsNullOrEmpty(textBoxID.Text) ||
           (String.IsNullOrEmpty(textBoxName.Text) ||
           (String.IsNullOrEmpty(textBoxStatus.Text) ||
           (String.IsNullOrEmpty(textBoxPD.Text)))))
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

            if (String.IsNullOrEmpty(textBoxStatus.Text))
            {
                MessageBox.Show("Некорректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBoxPD.Text))
            {
                MessageBox.Show("Некорректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand($@"INSERT INTO [Referee] (ID_Referee, Name_Referee, Passport_Data, Status) VALUES (@ID_Referee, @Name_Referee, @Passport_Data, @Status)", connection);


            command.Parameters.AddWithValue("ID_Referee", textBoxID.Text);
            command.Parameters.AddWithValue("Name_Referee", textBoxName.Text);
            command.Parameters.AddWithValue("Passport_Data", textBoxPD.Text);
            command.Parameters.AddWithValue("Status", textBoxStatus.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по добавлению выполнена");
            connection.Close();
                dataGridView1.DataSource = FillDataGridView(@"Select ID_Referee as '№', Name_Referee as 'Имя', Passport_Data as 'Серия и номер паспорта', Status as 'Категория' from Referee");
            }
            if (radioButtonManagers.Checked)
            {

                if (String.IsNullOrEmpty(textBoxID.Text) ||
           (String.IsNullOrEmpty(textBoxName.Text) ||
           (String.IsNullOrEmpty(textBoxPosition.Text) ||
           (String.IsNullOrEmpty(textBoxPD.Text)))))
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

                if (String.IsNullOrEmpty(textBoxStatus.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(textBoxPD.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand($@"INSERT INTO [Manager] (ID_Manager, Name_Manager, Passport_Data, Position) VALUES (@ID_Manager, @Name_Manager, @Passport_Data, @Position)", connection);


                command.Parameters.AddWithValue("ID_Manager", textBoxID.Text);
                command.Parameters.AddWithValue("Name_Manager", textBoxName.Text);
                command.Parameters.AddWithValue("Passport_Data", textBoxPD.Text);
                command.Parameters.AddWithValue("Position", textBoxStatus.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по добавлению выполнена");
                connection.Close();
                dataGridView1.DataSource = FillDataGridView(@"Select ID_Manager as '№', Name_Manager as 'Имя', Passport_Data as 'Серия и номер паспорта', Position as 'Должность' from Manager");
            }
            if (radioButtonSponsor.Checked)
            {
                if (String.IsNullOrEmpty(textBoxID.Text) ||
           (String.IsNullOrEmpty(textBoxName.Text) ||
           (String.IsNullOrEmpty(textBoxCompany.Text) ||
           (String.IsNullOrEmpty(textBoxPD.Text)))))
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

                if (String.IsNullOrEmpty(textBoxCompany.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(textBoxPD.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand($@"INSERT INTO [Sponsor] (ID_Sponsor, Name_Sponsor, Passport_Data, Company) VALUES (@ID_Sponsor, @Name_Sponsor, @Passport_Data, @Company)", connection);


                command.Parameters.AddWithValue("ID_Sponsor", textBoxID.Text);
                command.Parameters.AddWithValue("Name_Sponsor", textBoxName.Text);
                command.Parameters.AddWithValue("Passport_Data", textBoxPD.Text);
                command.Parameters.AddWithValue("Company", textBoxCompany.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по добавлению выполнена");
                connection.Close();
                dataGridView1.DataSource = FillDataGridView(@"Select ID_Sponsor as '№', Name_Sponsor as 'Имя', Passport_Data as 'Серия и номер паспорта', Company as 'Компания' from Sponsor");
            }
            if (radioButtonRegulation.Checked)
            {
                if (String.IsNullOrEmpty(textBoxID.Text) ||
            (String.IsNullOrEmpty(textBoxDate.Text) ||
            (String.IsNullOrEmpty(textBoxRegName.Text) ||
            (String.IsNullOrEmpty(textBoxID_S.Text) ||
            (String.IsNullOrEmpty(textBoxID_M.Text) ||
            (String.IsNullOrEmpty(textBoxID_ref.Text) ||
            (String.IsNullOrEmpty(textBoxCount.Text))))))))
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


                if (String.IsNullOrEmpty(textBoxDate.Text))
                {
                    MessageBox.Show("Некоректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (String.IsNullOrEmpty(textBoxRegName.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(textBoxCount.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(textBoxID_S.Text, out _))
                {
                    MessageBox.Show("Некоректное значение ID!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(textBoxID_M.Text, out _))
                {
                    MessageBox.Show("Некоректное значение ID!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(textBoxID_ref.Text, out _))
                {
                    MessageBox.Show("Некоректное значение ID!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand($@"INSERT INTO [Regulation] (Regulation_Number, Date_of_Regulation, Regulation_Name, Count_of_Members, ID_Sponsor, ID_Referee, ID_Manager) VALUES (@Regulation_Number, @Date_of_Regulation, @Regulation_Name, @Count_of_Members, @ID_Sponsor, @ID_Referee, @ID_Manager)", connection);


                command.Parameters.AddWithValue("Regulation_Number", textBoxID.Text);
                command.Parameters.AddWithValue("Date_of_Regulation", textBoxDate.Text);
                command.Parameters.AddWithValue("Regulation_Name", textBoxRegName.Text);
                command.Parameters.AddWithValue("Count_of_Members", textBoxCount.Text);
                command.Parameters.AddWithValue("ID_Sponsor", textBoxID_S.Text);
                command.Parameters.AddWithValue("ID_Manager", textBoxID_M.Text);
                command.Parameters.AddWithValue("ID_Referee", textBoxID_ref.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по добавлению выполнена");
                connection.Close();
                dataGridView1.DataSource = FillDataGridView(@"Select Regulation_Number as '№ положения', Date_of_Regulation as 'Дата проведения', Regulation_Name as 'Название соревнования', Count_of_Members as 'Кол-во участников', ID_Manager, ID_Sponsor, ID_Referee from Regulation");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (radioButtonReferee.Checked)
            {
                if (String.IsNullOrEmpty(textBoxID.Text) ||
           (String.IsNullOrEmpty(textBoxName.Text) ||
           (String.IsNullOrEmpty(textBoxStatus.Text) ||
           (String.IsNullOrEmpty(textBoxPD.Text)))))
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

                if (String.IsNullOrEmpty(textBoxStatus.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(textBoxPD.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand($@"UPDATE Referee SET ID_Referee = @ID_Referee, Name_Referee = @Name_Referee, Passport_Data = @Passport_Data, Status = @Status WHERE ID_Referee = @ID_Referee", connection);


                command.Parameters.AddWithValue("ID_Referee", textBoxID.Text);
                command.Parameters.AddWithValue("Name_Referee", textBoxName.Text);
                command.Parameters.AddWithValue("Passport_Data", textBoxPD.Text);
                command.Parameters.AddWithValue("Status", textBoxStatus.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по изменению выполнена");
                connection.Close();

                dataGridView1.DataSource = FillDataGridView(@"Select ID_Referee as '№', Name_Referee as 'Имя', Passport_Data as 'Серия и номер паспорта', Status as 'Категория' from Referee");
            }
            if (radioButtonManagers.Checked)
            {
                if (String.IsNullOrEmpty(textBoxID.Text) ||
           (String.IsNullOrEmpty(textBoxName.Text) ||
           (String.IsNullOrEmpty(textBoxPosition.Text) ||
           (String.IsNullOrEmpty(textBoxPD.Text)))))
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

                if (String.IsNullOrEmpty(textBoxStatus.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(textBoxPD.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand($@"UPDATE Manager SET ID_Manager = @ID_Manager, Name_Manager = @Name_Manager, Passport_Data = @Passport_Data, Position = @Position WHERE ID_Manager = @ID_Manager", connection);


                command.Parameters.AddWithValue("ID_Manager", textBoxID.Text);
                command.Parameters.AddWithValue("Name_Manager", textBoxName.Text);
                command.Parameters.AddWithValue("Passport_Data", textBoxPD.Text);
                command.Parameters.AddWithValue("Position", textBoxStatus.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по изменению выполнена");
                connection.Close();
                dataGridView1.DataSource = FillDataGridView(@"Select ID_Manager as '№', Name_Manager as 'Имя', Passport_Data as 'Серия и номер паспорта', Position as 'Должность' from Manager");
            }
            if (radioButtonSponsor.Checked)
            {
                if (String.IsNullOrEmpty(textBoxID.Text) ||
           (String.IsNullOrEmpty(textBoxName.Text) ||
           (String.IsNullOrEmpty(textBoxCompany.Text) ||
           (String.IsNullOrEmpty(textBoxPD.Text)))))
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

                if (String.IsNullOrEmpty(textBoxCompany.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(textBoxPD.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand($@"UPDATE Sponsor SET ID_Sponsor = @ID_Sponsor, Name_Sponsor = @Name_Sponsor, Passport_Data = @Passport_Data, Company = @Company WHERE ID_Sponsor = @ID_Sponsor", connection);


                command.Parameters.AddWithValue("ID_Sponsor", textBoxID.Text);
                command.Parameters.AddWithValue("Name_Sponsor", textBoxName.Text);
                command.Parameters.AddWithValue("Passport_Data", textBoxPD.Text);
                command.Parameters.AddWithValue("Company", textBoxCompany.Text);
                
                MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по изменению выполнена");
                connection.Close();
                dataGridView1.DataSource = FillDataGridView(@"Select ID_Sponsor as '№', Name_Sponsor as 'Имя', Passport_Data as 'Серия и номер паспорта', Company as 'Компания' from Sponsor");

            }
            if (radioButtonRegulation.Checked)
            {
                if (String.IsNullOrEmpty(textBoxID.Text) ||
            (String.IsNullOrEmpty(textBoxDate.Text) ||
            (String.IsNullOrEmpty(textBoxRegName.Text) ||
            (String.IsNullOrEmpty(textBoxID_S.Text) ||
            (String.IsNullOrEmpty(textBoxID_M.Text) ||
            (String.IsNullOrEmpty(textBoxID_ref.Text) ||
            (String.IsNullOrEmpty(textBoxCount.Text))))))))
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


                if (String.IsNullOrEmpty(textBoxDate.Text))
                {
                    MessageBox.Show("Некоректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (String.IsNullOrEmpty(textBoxRegName.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(textBoxCount.Text))
                {
                    MessageBox.Show("Некорректное значение!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(textBoxID_S.Text, out _))
                {
                    MessageBox.Show("Некоректное значение ID!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(textBoxID_M.Text, out _))
                {
                    MessageBox.Show("Некоректное значение ID!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(textBoxID_ref.Text, out _))
                {
                    MessageBox.Show("Некоректное значение ID!", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ChampionshipConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand($@"UPDATE Regulation SET Regulation_Number = @Regulation_Number, 
Date_of_Regulation = @Date_of_Regulation , Regulation_Name = @Regulation_Name, Count_of_Members = @Count_of_Members, 
ID_Sponsor = @ID_Sponsor, ID_Referee = @ID_Referee, ID_Manager = @ID_Manager 
WHERE @Regulation_Number = Regulation_Number", connection);


                command.Parameters.AddWithValue("Regulation_Number", textBoxID.Text);
                command.Parameters.AddWithValue("Date_of_Regulation", textBoxDate.Text);
                command.Parameters.AddWithValue("Regulation_Name", textBoxRegName.Text);
                command.Parameters.AddWithValue("Count_of_Members", textBoxCount.Text);
                command.Parameters.AddWithValue("ID_Sponsor", textBoxID_S.Text);
                command.Parameters.AddWithValue("ID_Manager", textBoxID_M.Text);
                command.Parameters.AddWithValue("ID_Referee", textBoxID_ref.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по изменению выполнена");
                connection.Close();
                dataGridView1.DataSource = FillDataGridView(@"Select Regulation_Number as '№ положения', Date_of_Regulation as 'Дата проведения', Regulation_Name as 'Название соревнования', Count_of_Members as 'Кол-во участников', ID_Manager, ID_Sponsor, ID_Referee from Regulation");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (radioButtonReferee.Checked == true)
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
                SqlCommand command = new SqlCommand($@"DELETE FROM Referee WHERE  ID_Referee = @ID_Referee", connection);

                command.Parameters.AddWithValue("ID_Referee", textBoxID.Text);

                MessageBox.Show(command.ExecuteNonQuery().ToString() + " команда по удалению выполнена");
                connection.Close();
                dataGridView1.DataSource = FillDataGridView(@"Select ID_Referee as '№', Name_Referee as 'Имя', Passport_Data as 'Серия и номер паспорта', Status as 'Категория' from Referee");

            }
            if (radioButtonManagers.Checked == true)
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
                SqlCommand command = new SqlCommand($@"DELETE FROM Manager WHERE  ID_Manager = @ID_Manager", connection);

                command.Parameters.AddWithValue("ID_Manager", textBoxID.Text);

                MessageBox.Show(command.ExecuteNonQuery().ToString() + " команда по удалению выполнена");
                connection.Close();
                dataGridView1.DataSource = FillDataGridView(@"Select ID_Manager as '№', Name_Manager as 'Имя', Passport_Data as 'Серия и номер паспорта', Position as 'Должность' from Manager");

            }
            if (radioButtonSponsor.Checked == true)
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
                SqlCommand command = new SqlCommand($@"DELETE FROM Sponsor WHERE  ID_Sponsor = @ID_Sponsor", connection);

                command.Parameters.AddWithValue("ID_Sponsor", textBoxID.Text);

                MessageBox.Show(command.ExecuteNonQuery().ToString() + " команда по удалению выполнена");
                connection.Close();
                dataGridView1.DataSource = FillDataGridView(@"Select ID_Sponsor as '№', Name_Sponsor as 'Имя', Passport_Data as 'Серия и номер паспорта', Company as 'Компания' from Sponsor");

            }
            if (radioButtonRegulation.Checked == true)
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
                SqlCommand command = new SqlCommand($@"DELETE FROM Regulation WHERE  Regulation_Number = @Regulation_Number", connection);

                command.Parameters.AddWithValue("Regulation_Number", textBoxID.Text);

                MessageBox.Show(command.ExecuteNonQuery().ToString() + " команда по удалению выполнена");
                connection.Close();
                dataGridView1.DataSource = FillDataGridView(@"Select Regulation_Number as '№ положения', Date_of_Regulation as 'Дата проведения', Regulation_Name as 'Название соревнования', Count_of_Members as 'Кол-во участников', ID_Manager, ID_Sponsor, ID_Referee from Regulation");
            }
        }

        private void radioButtonRegulation_CheckedChanged(object sender, EventArgs e)
        {
            textBoxID.Show();
            textBoxID_M.Show();
            textBoxID_S.Show();
            textBoxID_ref.Show();
            textBoxRegName.Show();
            textBoxCount.Show();
            textBoxDate.Show();
            textBoxName.Hide();
            textBoxPD.Hide();
            textBoxStatus.Hide();
            textBoxPosition.Hide();
            textBoxCompany.Hide();
        }

        private void radioButtonReferee_CheckedChanged(object sender, EventArgs e)
        {
            textBoxID.Show();
            textBoxID_M.Hide();
            textBoxID_S.Hide();
            textBoxID_ref.Hide();
            textBoxRegName.Hide();
            textBoxCount.Hide();
            textBoxDate.Hide();
            textBoxName.Show();
            textBoxPD.Show();
            textBoxStatus.Show();
            textBoxPosition.Hide();
            textBoxCompany.Hide();
        }

        private void radioButtonManagers_CheckedChanged(object sender, EventArgs e)
        {
            textBoxID.Show();
            textBoxID_M.Hide();
            textBoxID_S.Hide();
            textBoxID_ref.Hide();
            textBoxRegName.Hide();
            textBoxCount.Hide();
            textBoxDate.Hide();
            textBoxName.Show();
            textBoxPD.Show();
            textBoxStatus.Hide();
            textBoxPosition.Show();
            textBoxCompany.Hide();
        }

        private void radioButtonSponsor_CheckedChanged(object sender, EventArgs e)
        {
            textBoxID.Show();
            textBoxID_M.Hide();
            textBoxID_S.Hide();
            textBoxID_ref.Hide();
            textBoxRegName.Hide();
            textBoxCount.Hide();
            textBoxDate.Hide();
            textBoxName.Show();
            textBoxPD.Show();
            textBoxStatus.Hide();
            textBoxPosition.Hide();
            textBoxCompany.Show();
        }
    }
}
