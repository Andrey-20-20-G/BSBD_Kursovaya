namespace BSBD_Kursovaya
{
    partial class HRForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRForm));
            this.backbutton = new System.Windows.Forms.Button();
            this.championshipDataSet = new BSBD_Kursovaya.ChampionshipDataSet();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerTableAdapter = new BSBD_Kursovaya.ChampionshipDataSetTableAdapters.ManagerTableAdapter();
            this.tableAdapterManager = new BSBD_Kursovaya.ChampionshipDataSetTableAdapters.TableAdapterManager();
            this.managerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.managerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.radioButtonRegulation = new System.Windows.Forms.RadioButton();
            this.radioButtonReferee = new System.Windows.Forms.RadioButton();
            this.radioButtonSponsor = new System.Windows.Forms.RadioButton();
            this.radioButtonManagers = new System.Windows.Forms.RadioButton();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPD = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxRegName = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxID_M = new System.Windows.Forms.TextBox();
            this.textBoxID_S = new System.Windows.Forms.TextBox();
            this.textBoxID_ref = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.championshipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingNavigator)).BeginInit();
            this.managerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Lavender;
            this.backbutton.Location = new System.Drawing.Point(12, 562);
            this.backbutton.Name = "backbutton";
            this.backbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.backbutton.Size = new System.Drawing.Size(181, 65);
            this.backbutton.TabIndex = 1;
            this.backbutton.Text = "Назад";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // championshipDataSet
            // 
            this.championshipDataSet.DataSetName = "ChampionshipDataSet";
            this.championshipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "Manager";
            this.managerBindingSource.DataSource = this.championshipDataSet;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ManagerTableAdapter = this.managerTableAdapter;
            this.tableAdapterManager.PlayerTableAdapter = null;
            this.tableAdapterManager.RefereeTableAdapter = null;
            this.tableAdapterManager.RegulationTableAdapter = null;
            this.tableAdapterManager.SponsorTableAdapter = null;
            this.tableAdapterManager.TotalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSBD_Kursovaya.ChampionshipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // managerBindingNavigator
            // 
            this.managerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.managerBindingNavigator.BindingSource = this.managerBindingSource;
            this.managerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.managerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.managerBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.managerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.managerBindingNavigatorSaveItem});
            this.managerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.managerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.managerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.managerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.managerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.managerBindingNavigator.Name = "managerBindingNavigator";
            this.managerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.managerBindingNavigator.Size = new System.Drawing.Size(1295, 38);
            this.managerBindingNavigator.TabIndex = 2;
            this.managerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // managerBindingNavigatorSaveItem
            // 
            this.managerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.managerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("managerBindingNavigatorSaveItem.Image")));
            this.managerBindingNavigatorSaveItem.Name = "managerBindingNavigatorSaveItem";
            this.managerBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.managerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.managerBindingNavigatorSaveItem.Click += new System.EventHandler(this.managerBindingNavigatorSaveItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(876, 349);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.Lavender;
            this.buttonSelect.Location = new System.Drawing.Point(907, 73);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSelect.Size = new System.Drawing.Size(181, 65);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Показать данные";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Lavender;
            this.buttonDelete.Location = new System.Drawing.Point(907, 321);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDelete.Size = new System.Drawing.Size(181, 65);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить данные";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Lavender;
            this.buttonUpdate.Location = new System.Drawing.Point(907, 239);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonUpdate.Size = new System.Drawing.Size(181, 65);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Изменить данные";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Lavender;
            this.buttonInsert.Location = new System.Drawing.Point(907, 159);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonInsert.Size = new System.Drawing.Size(181, 65);
            this.buttonInsert.TabIndex = 7;
            this.buttonInsert.Text = "Добавить данные";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // radioButtonRegulation
            // 
            this.radioButtonRegulation.AutoSize = true;
            this.radioButtonRegulation.Location = new System.Drawing.Point(37, 426);
            this.radioButtonRegulation.Name = "radioButtonRegulation";
            this.radioButtonRegulation.Size = new System.Drawing.Size(121, 24);
            this.radioButtonRegulation.TabIndex = 8;
            this.radioButtonRegulation.TabStop = true;
            this.radioButtonRegulation.Text = "Положение";
            this.radioButtonRegulation.UseVisualStyleBackColor = true;
            this.radioButtonRegulation.CheckedChanged += new System.EventHandler(this.radioButtonRegulation_CheckedChanged);
            // 
            // radioButtonReferee
            // 
            this.radioButtonReferee.AutoSize = true;
            this.radioButtonReferee.Location = new System.Drawing.Point(238, 427);
            this.radioButtonReferee.Name = "radioButtonReferee";
            this.radioButtonReferee.Size = new System.Drawing.Size(81, 24);
            this.radioButtonReferee.TabIndex = 9;
            this.radioButtonReferee.TabStop = true;
            this.radioButtonReferee.Text = "Судьи";
            this.radioButtonReferee.UseVisualStyleBackColor = true;
            this.radioButtonReferee.CheckedChanged += new System.EventHandler(this.radioButtonReferee_CheckedChanged);
            // 
            // radioButtonSponsor
            // 
            this.radioButtonSponsor.AutoSize = true;
            this.radioButtonSponsor.Location = new System.Drawing.Point(238, 477);
            this.radioButtonSponsor.Name = "radioButtonSponsor";
            this.radioButtonSponsor.Size = new System.Drawing.Size(109, 24);
            this.radioButtonSponsor.TabIndex = 10;
            this.radioButtonSponsor.TabStop = true;
            this.radioButtonSponsor.Text = "Спонсоры";
            this.radioButtonSponsor.UseVisualStyleBackColor = true;
            this.radioButtonSponsor.CheckedChanged += new System.EventHandler(this.radioButtonSponsor_CheckedChanged);
            // 
            // radioButtonManagers
            // 
            this.radioButtonManagers.AutoSize = true;
            this.radioButtonManagers.Location = new System.Drawing.Point(37, 477);
            this.radioButtonManagers.Name = "radioButtonManagers";
            this.radioButtonManagers.Size = new System.Drawing.Size(144, 24);
            this.radioButtonManagers.TabIndex = 11;
            this.radioButtonManagers.TabStop = true;
            this.radioButtonManagers.Text = "Организаторы";
            this.radioButtonManagers.UseVisualStyleBackColor = true;
            this.radioButtonManagers.CheckedChanged += new System.EventHandler(this.radioButtonManagers_CheckedChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(420, 425);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(148, 44);
            this.textBoxID.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(420, 475);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(148, 44);
            this.textBoxName.TabIndex = 21;
            // 
            // textBoxPD
            // 
            this.textBoxPD.Location = new System.Drawing.Point(420, 525);
            this.textBoxPD.Multiline = true;
            this.textBoxPD.Name = "textBoxPD";
            this.textBoxPD.Size = new System.Drawing.Size(148, 44);
            this.textBoxPD.TabIndex = 22;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(1130, 73);
            this.textBoxPosition.Multiline = true;
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(148, 44);
            this.textBoxPosition.TabIndex = 23;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(1130, 260);
            this.textBoxCompany.Multiline = true;
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(148, 44);
            this.textBoxCompany.TabIndex = 25;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(1130, 169);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(148, 44);
            this.textBoxStatus.TabIndex = 26;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(574, 425);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(93, 40);
            this.labelID.TabIndex = 27;
            this.labelID.Text = "ID/номер \r\nположения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 40);
            this.label3.TabIndex = 29;
            this.label3.Text = "Паспортные\r\nданные\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1157, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1163, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Категория";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1144, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Организация";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(683, 475);
            this.textBoxDate.Multiline = true;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(148, 44);
            this.textBoxDate.TabIndex = 34;
            // 
            // textBoxRegName
            // 
            this.textBoxRegName.Location = new System.Drawing.Point(683, 522);
            this.textBoxRegName.Multiline = true;
            this.textBoxRegName.Name = "textBoxRegName";
            this.textBoxRegName.Size = new System.Drawing.Size(148, 44);
            this.textBoxRegName.TabIndex = 35;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(977, 427);
            this.textBoxCount.Multiline = true;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(148, 44);
            this.textBoxCount.TabIndex = 36;
            // 
            // textBoxID_M
            // 
            this.textBoxID_M.Location = new System.Drawing.Point(977, 475);
            this.textBoxID_M.Multiline = true;
            this.textBoxID_M.Name = "textBoxID_M";
            this.textBoxID_M.Size = new System.Drawing.Size(148, 44);
            this.textBoxID_M.TabIndex = 37;
            // 
            // textBoxID_S
            // 
            this.textBoxID_S.Location = new System.Drawing.Point(977, 525);
            this.textBoxID_S.Multiline = true;
            this.textBoxID_S.Name = "textBoxID_S";
            this.textBoxID_S.Size = new System.Drawing.Size(148, 44);
            this.textBoxID_S.TabIndex = 38;
            // 
            // textBoxID_ref
            // 
            this.textBoxID_ref.Location = new System.Drawing.Point(828, 583);
            this.textBoxID_ref.Multiline = true;
            this.textBoxID_ref.Name = "textBoxID_ref";
            this.textBoxID_ref.Size = new System.Drawing.Size(148, 44);
            this.textBoxID_ref.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(851, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 40);
            this.label7.TabIndex = 41;
            this.label7.Text = "Дата \r\nпроведения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(851, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 40);
            this.label8.TabIndex = 42;
            this.label8.Text = "Название\r\nсоревнования\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1131, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 40);
            this.label9.TabIndex = 43;
            this.label9.Text = "Кол-во\r\nучастников";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1131, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "ID_man\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1131, 525);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "ID_Sp\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(992, 595);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "ID_ref\r\n";
            // 
            // HRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1295, 639);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxID_ref);
            this.Controls.Add(this.textBoxID_S);
            this.Controls.Add(this.textBoxID_M);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxRegName);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.textBoxPD);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.radioButtonManagers);
            this.Controls.Add(this.radioButtonSponsor);
            this.Controls.Add(this.radioButtonReferee);
            this.Controls.Add(this.radioButtonRegulation);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.managerBindingNavigator);
            this.Controls.Add(this.backbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HRForm";
            this.Text = "Данные о сотрудниках";
            this.Load += new System.EventHandler(this.HRForm_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.championshipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingNavigator)).EndInit();
            this.managerBindingNavigator.ResumeLayout(false);
            this.managerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private ChampionshipDataSet championshipDataSet;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private ChampionshipDataSetTableAdapters.ManagerTableAdapter managerTableAdapter;
        private ChampionshipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator managerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton managerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.RadioButton radioButtonRegulation;
        private System.Windows.Forms.RadioButton radioButtonReferee;
        private System.Windows.Forms.RadioButton radioButtonSponsor;
        private System.Windows.Forms.RadioButton radioButtonManagers;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPD;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxRegName;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxID_M;
        private System.Windows.Forms.TextBox textBoxID_S;
        private System.Windows.Forms.TextBox textBoxID_ref;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}