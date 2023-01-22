namespace BSBD_Kursovaya
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PlayersInfo = new System.Windows.Forms.Label();
            this.RefereeInfo = new System.Windows.Forms.Label();
            this.HR = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LogOut_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayersInfo
            // 
            this.PlayersInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlayersInfo.Font = new System.Drawing.Font("Mistral", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayersInfo.Location = new System.Drawing.Point(-6, 0);
            this.PlayersInfo.Name = "PlayersInfo";
            this.PlayersInfo.Size = new System.Drawing.Size(331, 623);
            this.PlayersInfo.TabIndex = 0;
            this.PlayersInfo.Text = "Информация \r\nучастников";
            this.PlayersInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayersInfo.Click += new System.EventHandler(this.PlayersInfo_Click);
            // 
            // RefereeInfo
            // 
            this.RefereeInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RefereeInfo.Font = new System.Drawing.Font("Mistral", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefereeInfo.Location = new System.Drawing.Point(293, 0);
            this.RefereeInfo.Name = "RefereeInfo";
            this.RefereeInfo.Size = new System.Drawing.Size(304, 623);
            this.RefereeInfo.TabIndex = 1;
            this.RefereeInfo.Text = "Информация для судей";
            this.RefereeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefereeInfo.Click += new System.EventHandler(this.RefereeInfo_Click);
            // 
            // HR
            // 
            this.HR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HR.Font = new System.Drawing.Font("Mistral", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HR.Location = new System.Drawing.Point(593, 0);
            this.HR.Name = "HR";
            this.HR.Size = new System.Drawing.Size(379, 623);
            this.HR.TabIndex = 2;
            this.HR.Text = "Организационные\r\nданные";
            this.HR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HR.Click += new System.EventHandler(this.HR_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(18, 429);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(943, 4);
            this.listBox1.TabIndex = 3;
            // 
            // LogOut_button
            // 
            this.LogOut_button.BackColor = System.Drawing.Color.Lavender;
            this.LogOut_button.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut_button.Location = new System.Drawing.Point(12, 545);
            this.LogOut_button.Name = "LogOut_button";
            this.LogOut_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogOut_button.Size = new System.Drawing.Size(943, 65);
            this.LogOut_button.TabIndex = 4;
            this.LogOut_button.Text = "Выход из учетной записи";
            this.LogOut_button.UseVisualStyleBackColor = false;
            this.LogOut_button.Click += new System.EventHandler(this.LogOut_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 622);
            this.Controls.Add(this.LogOut_button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.HR);
            this.Controls.Add(this.RefereeInfo);
            this.Controls.Add(this.PlayersInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PlayersInfo;
        private System.Windows.Forms.Label RefereeInfo;
        private System.Windows.Forms.Label HR;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button LogOut_button;
    }
}