namespace BSBD_Kursovaya
{
    partial class PlayersForm
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
            System.Windows.Forms.Label regulation_NumberLabel;
            System.Windows.Forms.Label date_of_regulationLabel;
            System.Windows.Forms.Label regulation_NameLabel;
            System.Windows.Forms.Label count_of_membersLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayersForm));
            this.backbutton = new System.Windows.Forms.Button();
            this.championshipDataSet = new BSBD_Kursovaya.ChampionshipDataSet();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerTableAdapter = new BSBD_Kursovaya.ChampionshipDataSetTableAdapters.PlayerTableAdapter();
            this.tableAdapterManager = new BSBD_Kursovaya.ChampionshipDataSetTableAdapters.TableAdapterManager();
            this.regulationTableAdapter = new BSBD_Kursovaya.ChampionshipDataSetTableAdapters.RegulationTableAdapter();
            this.regulationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regulation_NumberTextBox = new System.Windows.Forms.TextBox();
            this.date_of_regulationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.regulation_NameTextBox = new System.Windows.Forms.TextBox();
            this.count_of_membersTextBox = new System.Windows.Forms.TextBox();
            this.regulationBinding = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.ResPlayers = new System.Windows.Forms.Button();
            this.dataGridViewWithRes = new System.Windows.Forms.DataGridView();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.CheckName = new System.Windows.Forms.CheckBox();
            regulation_NumberLabel = new System.Windows.Forms.Label();
            date_of_regulationLabel = new System.Windows.Forms.Label();
            regulation_NameLabel = new System.Windows.Forms.Label();
            count_of_membersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.championshipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regulationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regulationBinding)).BeginInit();
            this.regulationBinding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithRes)).BeginInit();
            this.SuspendLayout();
            // 
            // regulation_NumberLabel
            // 
            regulation_NumberLabel.AutoSize = true;
            regulation_NumberLabel.Location = new System.Drawing.Point(12, 55);
            regulation_NumberLabel.Name = "regulation_NumberLabel";
            regulation_NumberLabel.Size = new System.Drawing.Size(93, 40);
            regulation_NumberLabel.TabIndex = 3;
            regulation_NumberLabel.Text = "Номер \r\nположения";
            // 
            // date_of_regulationLabel
            // 
            date_of_regulationLabel.AutoSize = true;
            date_of_regulationLabel.Location = new System.Drawing.Point(8, 135);
            date_of_regulationLabel.Name = "date_of_regulationLabel";
            date_of_regulationLabel.Size = new System.Drawing.Size(144, 20);
            date_of_regulationLabel.TabIndex = 5;
            date_of_regulationLabel.Text = "Дата проведения";
            // 
            // regulation_NameLabel
            // 
            regulation_NameLabel.AutoSize = true;
            regulation_NameLabel.Location = new System.Drawing.Point(12, 204);
            regulation_NameLabel.Name = "regulation_NameLabel";
            regulation_NameLabel.Size = new System.Drawing.Size(110, 40);
            regulation_NameLabel.TabIndex = 7;
            regulation_NameLabel.Text = "Название \r\nмероприятия";
            // 
            // count_of_membersLabel
            // 
            count_of_membersLabel.AutoSize = true;
            count_of_membersLabel.Location = new System.Drawing.Point(8, 288);
            count_of_membersLabel.Name = "count_of_membersLabel";
            count_of_membersLabel.Size = new System.Drawing.Size(151, 20);
            count_of_membersLabel.TabIndex = 9;
            count_of_membersLabel.Text = "Кол-во участников";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Lavender;
            this.backbutton.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(12, 541);
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
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.championshipDataSet;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.PlayerTableAdapter = this.playerTableAdapter;
            this.tableAdapterManager.RefereeTableAdapter = null;
            this.tableAdapterManager.RegulationTableAdapter = this.regulationTableAdapter;
            this.tableAdapterManager.SponsorTableAdapter = null;
            this.tableAdapterManager.TotalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSBD_Kursovaya.ChampionshipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // regulationTableAdapter
            // 
            this.regulationTableAdapter.ClearBeforeFill = true;
            // 
            // regulationBindingSource
            // 
            this.regulationBindingSource.DataMember = "Regulation";
            this.regulationBindingSource.DataSource = this.championshipDataSet;
            // 
            // regulation_NumberTextBox
            // 
            this.regulation_NumberTextBox.BackColor = System.Drawing.Color.Lavender;
            this.regulation_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regulationBindingSource, "Regulation_Number", true));
            this.regulation_NumberTextBox.Location = new System.Drawing.Point(168, 55);
            this.regulation_NumberTextBox.Multiline = true;
            this.regulation_NumberTextBox.Name = "regulation_NumberTextBox";
            this.regulation_NumberTextBox.Size = new System.Drawing.Size(200, 43);
            this.regulation_NumberTextBox.TabIndex = 4;
            // 
            // date_of_regulationDateTimePicker
            // 
            this.date_of_regulationDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.date_of_regulationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.regulationBindingSource, "Date_of_regulation", true));
            this.date_of_regulationDateTimePicker.Location = new System.Drawing.Point(168, 135);
            this.date_of_regulationDateTimePicker.Name = "date_of_regulationDateTimePicker";
            this.date_of_regulationDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.date_of_regulationDateTimePicker.TabIndex = 6;
            // 
            // regulation_NameTextBox
            // 
            this.regulation_NameTextBox.BackColor = System.Drawing.Color.Lavender;
            this.regulation_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regulationBindingSource, "Regulation_Name", true));
            this.regulation_NameTextBox.Location = new System.Drawing.Point(168, 201);
            this.regulation_NameTextBox.Multiline = true;
            this.regulation_NameTextBox.Name = "regulation_NameTextBox";
            this.regulation_NameTextBox.Size = new System.Drawing.Size(200, 43);
            this.regulation_NameTextBox.TabIndex = 8;
            // 
            // count_of_membersTextBox
            // 
            this.count_of_membersTextBox.BackColor = System.Drawing.Color.Lavender;
            this.count_of_membersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regulationBindingSource, "Count_of_members", true));
            this.count_of_membersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_of_membersTextBox.Location = new System.Drawing.Point(168, 275);
            this.count_of_membersTextBox.Multiline = true;
            this.count_of_membersTextBox.Name = "count_of_membersTextBox";
            this.count_of_membersTextBox.Size = new System.Drawing.Size(200, 43);
            this.count_of_membersTextBox.TabIndex = 10;
            // 
            // regulationBinding
            // 
            this.regulationBinding.AddNewItem = null;
            this.regulationBinding.AutoSize = false;
            this.regulationBinding.BackColor = System.Drawing.Color.Lavender;
            this.regulationBinding.BindingSource = this.regulationBindingSource;
            this.regulationBinding.CountItem = this.toolStripLabel1;
            this.regulationBinding.DeleteItem = null;
            this.regulationBinding.Dock = System.Windows.Forms.DockStyle.None;
            this.regulationBinding.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.regulationBinding.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.regulationBinding.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3});
            this.regulationBinding.Location = new System.Drawing.Point(9, 9);
            this.regulationBinding.MoveFirstItem = this.toolStripButton3;
            this.regulationBinding.MoveLastItem = this.toolStripButton6;
            this.regulationBinding.MoveNextItem = this.toolStripButton5;
            this.regulationBinding.MovePreviousItem = this.toolStripButton4;
            this.regulationBinding.Name = "regulationBinding";
            this.regulationBinding.PositionItem = this.toolStripTextBox1;
            this.regulationBinding.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.regulationBinding.Size = new System.Drawing.Size(425, 31);
            this.regulationBinding.TabIndex = 11;
            this.regulationBinding.Text = "regulationBindingSource";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 26);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(34, 26);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(34, 26);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 31);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(34, 26);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(34, 26);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(508, 9);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowHeadersWidth = 62;
            this.dataGridViewPlayers.RowTemplate.Height = 28;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(629, 299);
            this.dataGridViewPlayers.TabIndex = 12;
            // 
            // ResPlayers
            // 
            this.ResPlayers.BackColor = System.Drawing.Color.Lavender;
            this.ResPlayers.Location = new System.Drawing.Point(872, 553);
            this.ResPlayers.Name = "ResPlayers";
            this.ResPlayers.Size = new System.Drawing.Size(256, 53);
            this.ResPlayers.TabIndex = 13;
            this.ResPlayers.Text = "Таблица результатов";
            this.ResPlayers.UseVisualStyleBackColor = false;
            this.ResPlayers.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewWithRes
            // 
            this.dataGridViewWithRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWithRes.Location = new System.Drawing.Point(310, 327);
            this.dataGridViewWithRes.Name = "dataGridViewWithRes";
            this.dataGridViewWithRes.RowHeadersWidth = 62;
            this.dataGridViewWithRes.RowTemplate.Height = 28;
            this.dataGridViewWithRes.Size = new System.Drawing.Size(827, 296);
            this.dataGridViewWithRes.TabIndex = 14;
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Font = new System.Drawing.Font("MV Boli", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchName.Location = new System.Drawing.Point(9, 373);
            this.textBoxSearchName.Multiline = true;
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(281, 56);
            this.textBoxSearchName.TabIndex = 15;
            // 
            // CheckName
            // 
            this.CheckName.AutoSize = true;
            this.CheckName.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckName.Location = new System.Drawing.Point(79, 457);
            this.CheckName.Name = "CheckName";
            this.CheckName.Size = new System.Drawing.Size(211, 33);
            this.CheckName.TabIndex = 16;
            this.CheckName.Text = "Поиск по имени";
            this.CheckName.UseVisualStyleBackColor = true;
            this.CheckName.CheckedChanged += new System.EventHandler(this.CheckName_CheckedChanged);
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1140, 626);
            this.Controls.Add(this.CheckName);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.dataGridViewWithRes);
            this.Controls.Add(this.ResPlayers);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.regulationBinding);
            this.Controls.Add(regulation_NumberLabel);
            this.Controls.Add(this.regulation_NumberTextBox);
            this.Controls.Add(date_of_regulationLabel);
            this.Controls.Add(this.date_of_regulationDateTimePicker);
            this.Controls.Add(regulation_NameLabel);
            this.Controls.Add(this.regulation_NameTextBox);
            this.Controls.Add(count_of_membersLabel);
            this.Controls.Add(this.count_of_membersTextBox);
            this.Controls.Add(this.backbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация об участниках";
            this.Load += new System.EventHandler(this.PlayersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.championshipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regulationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regulationBinding)).EndInit();
            this.regulationBinding.ResumeLayout(false);
            this.regulationBinding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private ChampionshipDataSet championshipDataSet;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private ChampionshipDataSetTableAdapters.PlayerTableAdapter playerTableAdapter;
        private ChampionshipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ChampionshipDataSetTableAdapters.RegulationTableAdapter regulationTableAdapter;
        private System.Windows.Forms.BindingSource regulationBindingSource;
        private System.Windows.Forms.TextBox regulation_NumberTextBox;
        private System.Windows.Forms.DateTimePicker date_of_regulationDateTimePicker;
        private System.Windows.Forms.TextBox regulation_NameTextBox;
        private System.Windows.Forms.TextBox count_of_membersTextBox;
        private System.Windows.Forms.BindingNavigator regulationBinding;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.Button ResPlayers;
        private System.Windows.Forms.DataGridView dataGridViewWithRes;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.CheckBox CheckName;
    }
}