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

namespace BSBD_Kursovaya.ManagerFolder
{
    public partial class Employee : Form
    {
        public Employee()
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

        private void managerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.championshipDataSet);

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "championshipDataSet.Sponsor". При необходимости она может быть перемещена или удалена.
            this.sponsorTableAdapter.Fill(this.championshipDataSet.Sponsor);
            //managerDataGridView.DataSource = FillDataGridView(@"Select ID_Manager as '№', Name_Manager as 'Имя', Passport_Data as 'Серия и номер паспорта', Position as 'Должность' from Manager");

            // TODO: данная строка кода позволяет загрузить данные в таблицу "championshipDataSet.Referee". При необходимости она может быть перемещена или удалена.
            this.refereeTableAdapter.Fill(this.championshipDataSet.Referee);
            //refereeDataGridView.DataSource = FillDataGridView(@"Select ID_Referee as '№', Name_Referee as 'Имя', Passport_Data as 'Серия и номер паспорта', Status as 'Категория' from Referee");

            // TODO: данная строка кода позволяет загрузить данные в таблицу "championshipDataSet.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.championshipDataSet.Manager);
            //sponsorDataGridView.DataSource = FillDataGridView(@"Select ID_Sponsor as '№', Name_Sponsor as 'Имя', Passport_Data as 'Серия и номер паспорта', Company as 'Компания' from Sponsor");

        }
    }
}
