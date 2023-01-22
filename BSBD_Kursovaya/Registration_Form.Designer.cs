namespace BSBD_Kursovaya
{
    partial class Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Login_text = new System.Windows.Forms.TextBox();
            this.Password_text = new System.Windows.Forms.TextBox();
            this.Sign_on = new System.Windows.Forms.Button();
            this.Authorization_label = new System.Windows.Forms.Label();
            this.Repeat_Password_label = new System.Windows.Forms.Label();
            this.Repeat_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_label.Location = new System.Drawing.Point(42, 135);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(95, 41);
            this.Login_label.TabIndex = 4;
            this.Login_label.Text = "Login";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(42, 267);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(152, 41);
            this.Password_label.TabIndex = 5;
            this.Password_label.Text = "Password";
            // 
            // Login_text
            // 
            this.Login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_text.Location = new System.Drawing.Point(49, 179);
            this.Login_text.Multiline = true;
            this.Login_text.Name = "Login_text";
            this.Login_text.Size = new System.Drawing.Size(326, 59);
            this.Login_text.TabIndex = 6;
            // 
            // Password_text
            // 
            this.Password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_text.Location = new System.Drawing.Point(49, 311);
            this.Password_text.Multiline = true;
            this.Password_text.Name = "Password_text";
            this.Password_text.Size = new System.Drawing.Size(326, 59);
            this.Password_text.TabIndex = 7;
            // 
            // Sign_on
            // 
            this.Sign_on.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_on.Location = new System.Drawing.Point(49, 527);
            this.Sign_on.Name = "Sign_on";
            this.Sign_on.Size = new System.Drawing.Size(326, 55);
            this.Sign_on.TabIndex = 8;
            this.Sign_on.Text = "Sign on";
            this.Sign_on.UseVisualStyleBackColor = true;
            this.Sign_on.Click += new System.EventHandler(this.Sign_on_Click);
            // 
            // Authorization_label
            // 
            this.Authorization_label.AutoSize = true;
            this.Authorization_label.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization_label.Location = new System.Drawing.Point(30, 9);
            this.Authorization_label.Name = "Authorization_label";
            this.Authorization_label.Size = new System.Drawing.Size(433, 114);
            this.Authorization_label.TabIndex = 9;
            this.Authorization_label.Text = "Registration";
            // 
            // Repeat_Password_label
            // 
            this.Repeat_Password_label.AutoSize = true;
            this.Repeat_Password_label.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repeat_Password_label.Location = new System.Drawing.Point(42, 392);
            this.Repeat_Password_label.Name = "Repeat_Password_label";
            this.Repeat_Password_label.Size = new System.Drawing.Size(273, 41);
            this.Repeat_Password_label.TabIndex = 10;
            this.Repeat_Password_label.Text = "Repeat_Password";
            // 
            // Repeat_Password
            // 
            this.Repeat_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Repeat_Password.Location = new System.Drawing.Point(49, 436);
            this.Repeat_Password.Multiline = true;
            this.Repeat_Password.Name = "Repeat_Password";
            this.Repeat_Password.Size = new System.Drawing.Size(326, 59);
            this.Repeat_Password.TabIndex = 11;
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 609);
            this.Controls.Add(this.Repeat_Password);
            this.Controls.Add(this.Repeat_Password_label);
            this.Controls.Add(this.Authorization_label);
            this.Controls.Add(this.Sign_on);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.Login_text);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration_Form";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Login_text;
        private System.Windows.Forms.TextBox Password_text;
        private System.Windows.Forms.Button Sign_on;
        private System.Windows.Forms.Label Authorization_label;
        private System.Windows.Forms.Label Repeat_Password_label;
        private System.Windows.Forms.TextBox Repeat_Password;
    }
}