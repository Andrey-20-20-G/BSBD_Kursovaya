namespace BSBD_Kursovaya
{
    partial class Authorization_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization_Form));
            this.Authorization_label = new System.Windows.Forms.Label();
            this.Password_text = new System.Windows.Forms.TextBox();
            this.Login_textbox = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Registration_label = new System.Windows.Forms.Label();
            this.Authorization_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Authorization_label
            // 
            this.Authorization_label.AutoSize = true;
            this.Authorization_label.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization_label.Location = new System.Drawing.Point(47, 9);
            this.Authorization_label.Name = "Authorization_label";
            this.Authorization_label.Size = new System.Drawing.Size(492, 114);
            this.Authorization_label.TabIndex = 0;
            this.Authorization_label.Text = "Authorization";
            // 
            // Password_text
            // 
            this.Password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_text.Location = new System.Drawing.Point(66, 359);
            this.Password_text.Multiline = true;
            this.Password_text.Name = "Password_text";
            this.Password_text.Size = new System.Drawing.Size(326, 59);
            this.Password_text.TabIndex = 1;
            // 
            // Login_textbox
            // 
            this.Login_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_textbox.Location = new System.Drawing.Point(66, 222);
            this.Login_textbox.Multiline = true;
            this.Login_textbox.Name = "Login_textbox";
            this.Login_textbox.Size = new System.Drawing.Size(326, 59);
            this.Login_textbox.TabIndex = 2;
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_label.Location = new System.Drawing.Point(59, 178);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(95, 41);
            this.Login_label.TabIndex = 3;
            this.Login_label.Text = "Login";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(59, 315);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(152, 41);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Password";
            // 
            // Registration_label
            // 
            this.Registration_label.AutoSize = true;
            this.Registration_label.BackColor = System.Drawing.SystemColors.Control;
            this.Registration_label.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_label.ForeColor = System.Drawing.Color.Cyan;
            this.Registration_label.Location = new System.Drawing.Point(228, 561);
            this.Registration_label.Name = "Registration_label";
            this.Registration_label.Size = new System.Drawing.Size(79, 28);
            this.Registration_label.TabIndex = 5;
            this.Registration_label.Text = "Sign up";
            this.Registration_label.Click += new System.EventHandler(this.Registration_label_Click);
            // 
            // Authorization_button
            // 
            this.Authorization_button.Location = new System.Drawing.Point(66, 445);
            this.Authorization_button.Name = "Authorization_button";
            this.Authorization_button.Size = new System.Drawing.Size(326, 55);
            this.Authorization_button.TabIndex = 6;
            this.Authorization_button.Text = "Log in";
            this.Authorization_button.UseVisualStyleBackColor = true;
            this.Authorization_button.Click += new System.EventHandler(this.Authorization_button_Click);
            // 
            // Authorization_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 609);
            this.Controls.Add(this.Authorization_button);
            this.Controls.Add(this.Registration_label);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Login_textbox);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.Authorization_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization_Form";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Authorization_label;
        private System.Windows.Forms.TextBox Password_text;
        private System.Windows.Forms.TextBox Login_textbox;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label Registration_label;
        private System.Windows.Forms.Button Authorization_button;
    }
}

