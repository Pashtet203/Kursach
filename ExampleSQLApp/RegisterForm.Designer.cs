namespace ExampleSQLApp
{
    partial class RegisterForm
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
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegistrationPatronymicField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegistrationDateOfBrithdayField = new System.Windows.Forms.TextBox();
            this.RegistrationNameField = new System.Windows.Forms.TextBox();
            this.RegistrationSurnameField = new System.Windows.Forms.TextBox();
            this.RegistrationLocationField = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfrimPass = new System.Windows.Forms.TextBox();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            this.checkBoxPassConfrim = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PapayaWhip;
            this.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(342, 300);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(188, 29);
            this.RegisterButton.TabIndex = 15;
            this.RegisterButton.Text = "Зарегистроваться";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegistrationPatronymicField
            // 
            this.RegistrationPatronymicField.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationPatronymicField.Location = new System.Drawing.Point(138, 167);
            this.RegistrationPatronymicField.MaxLength = 30;
            this.RegistrationPatronymicField.Name = "RegistrationPatronymicField";
            this.RegistrationPatronymicField.Size = new System.Drawing.Size(242, 33);
            this.RegistrationPatronymicField.TabIndex = 14;
            this.RegistrationPatronymicField.Enter += new System.EventHandler(this.RegistrationPatronymicField_Enter);
            this.RegistrationPatronymicField.Leave += new System.EventHandler(this.RegistrationPatronymicField_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 450);
            this.panel1.TabIndex = 9;
            // 
            // RegistrationDateOfBrithdayField
            // 
            this.RegistrationDateOfBrithdayField.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationDateOfBrithdayField.Location = new System.Drawing.Point(461, 109);
            this.RegistrationDateOfBrithdayField.MaxLength = 10;
            this.RegistrationDateOfBrithdayField.Multiline = true;
            this.RegistrationDateOfBrithdayField.Name = "RegistrationDateOfBrithdayField";
            this.RegistrationDateOfBrithdayField.Size = new System.Drawing.Size(243, 32);
            this.RegistrationDateOfBrithdayField.TabIndex = 19;
            this.RegistrationDateOfBrithdayField.Enter += new System.EventHandler(this.RegistrationDateOfBrithdayField_Enter);
            this.RegistrationDateOfBrithdayField.Leave += new System.EventHandler(this.RegistrationDateOfBrithdayField_Leave);
            // 
            // RegistrationNameField
            // 
            this.RegistrationNameField.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationNameField.Location = new System.Drawing.Point(138, 109);
            this.RegistrationNameField.MaxLength = 20;
            this.RegistrationNameField.Multiline = true;
            this.RegistrationNameField.Name = "RegistrationNameField";
            this.RegistrationNameField.Size = new System.Drawing.Size(242, 32);
            this.RegistrationNameField.TabIndex = 16;
            this.RegistrationNameField.Enter += new System.EventHandler(this.RegistrationNameFiled_Enter);
            this.RegistrationNameField.Leave += new System.EventHandler(this.RegistrationNameFiled_Leave);
            // 
            // RegistrationSurnameField
            // 
            this.RegistrationSurnameField.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationSurnameField.Location = new System.Drawing.Point(138, 57);
            this.RegistrationSurnameField.MaxLength = 30;
            this.RegistrationSurnameField.Multiline = true;
            this.RegistrationSurnameField.Name = "RegistrationSurnameField";
            this.RegistrationSurnameField.Size = new System.Drawing.Size(242, 32);
            this.RegistrationSurnameField.TabIndex = 17;
            this.RegistrationSurnameField.Enter += new System.EventHandler(this.RegistrationSurnameFiled_Enter);
            this.RegistrationSurnameField.Leave += new System.EventHandler(this.RegistrationSurnameFiled_Leave);
            // 
            // RegistrationLocationField
            // 
            this.RegistrationLocationField.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLocationField.Location = new System.Drawing.Point(461, 57);
            this.RegistrationLocationField.MaxLength = 100;
            this.RegistrationLocationField.Multiline = true;
            this.RegistrationLocationField.Name = "RegistrationLocationField";
            this.RegistrationLocationField.Size = new System.Drawing.Size(243, 32);
            this.RegistrationLocationField.TabIndex = 18;
            this.RegistrationLocationField.Enter += new System.EventHandler(this.RegistrationLocationField_Enter);
            this.RegistrationLocationField.Leave += new System.EventHandler(this.RegistrationLocationField_Leave);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(138, 225);
            this.textBoxLogin.MaxLength = 20;
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(242, 32);
            this.textBoxLogin.TabIndex = 20;
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(461, 168);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(243, 33);
            this.textBoxPassword.TabIndex = 21;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxConfrimPass
            // 
            this.textBoxConfrimPass.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConfrimPass.Location = new System.Drawing.Point(461, 225);
            this.textBoxConfrimPass.MaxLength = 20;
            this.textBoxConfrimPass.Name = "textBoxConfrimPass";
            this.textBoxConfrimPass.Size = new System.Drawing.Size(243, 33);
            this.textBoxConfrimPass.TabIndex = 22;
            this.textBoxConfrimPass.Enter += new System.EventHandler(this.textBoxConfrimPass_Enter);
            this.textBoxConfrimPass.Leave += new System.EventHandler(this.textBoxConfrimPass_Leave);
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.Location = new System.Drawing.Point(711, 186);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPass.TabIndex = 24;
            this.checkBoxPass.UseVisualStyleBackColor = true;
            this.checkBoxPass.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // checkBoxPassConfrim
            // 
            this.checkBoxPassConfrim.AutoSize = true;
            this.checkBoxPassConfrim.Location = new System.Drawing.Point(711, 239);
            this.checkBoxPassConfrim.Name = "checkBoxPassConfrim";
            this.checkBoxPassConfrim.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPassConfrim.TabIndex = 25;
            this.checkBoxPassConfrim.UseVisualStyleBackColor = true;
            this.checkBoxPassConfrim.CheckedChanged += new System.EventHandler(this.checkBoxPassConfrim_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.checkBoxPassConfrim);
            this.Controls.Add(this.checkBoxPass);
            this.Controls.Add(this.textBoxConfrimPass);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.RegistrationLocationField);
            this.Controls.Add(this.RegistrationSurnameField);
            this.Controls.Add(this.RegistrationNameField);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RegistrationPatronymicField);
            this.Controls.Add(this.RegistrationDateOfBrithdayField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button RegisterButton;
        public System.Windows.Forms.TextBox RegistrationPatronymicField;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox RegistrationDateOfBrithdayField;
        public System.Windows.Forms.TextBox RegistrationNameField;
        public System.Windows.Forms.TextBox RegistrationSurnameField;
        public System.Windows.Forms.TextBox RegistrationLocationField;
        public System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.CheckBox checkBoxPass;
        private System.Windows.Forms.CheckBox checkBoxPassConfrim;
        public System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.TextBox textBoxConfrimPass;
    }
}