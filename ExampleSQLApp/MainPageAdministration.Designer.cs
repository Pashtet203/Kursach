namespace ExampleSQLApp
{
    partial class MainPageAdministration
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonConfrim = new System.Windows.Forms.RadioButton();
            this.listBoxUserData = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCheckMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 450);
            this.label1.TabIndex = 6;
            // 
            // textBoxIDUser
            // 
            this.textBoxIDUser.Location = new System.Drawing.Point(123, 77);
            this.textBoxIDUser.Multiline = true;
            this.textBoxIDUser.Name = "textBoxIDUser";
            this.textBoxIDUser.Size = new System.Drawing.Size(135, 19);
            this.textBoxIDUser.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Указать ID пользователя";
            // 
            // radioButtonConfrim
            // 
            this.radioButtonConfrim.AutoSize = true;
            this.radioButtonConfrim.Location = new System.Drawing.Point(123, 335);
            this.radioButtonConfrim.Name = "radioButtonConfrim";
            this.radioButtonConfrim.Size = new System.Drawing.Size(160, 17);
            this.radioButtonConfrim.TabIndex = 9;
            this.radioButtonConfrim.TabStop = true;
            this.radioButtonConfrim.Text = "Подтвердить регистрацию";
            this.radioButtonConfrim.UseVisualStyleBackColor = true;
            // 
            // listBoxUserData
            // 
            this.listBoxUserData.FormattingEnabled = true;
            this.listBoxUserData.Location = new System.Drawing.Point(123, 133);
            this.listBoxUserData.Name = "listBoxUserData";
            this.listBoxUserData.Size = new System.Drawing.Size(254, 186);
            this.listBoxUserData.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Данные пользователя";
            // 
            // textBoxCheckMessage
            // 
            this.textBoxCheckMessage.Location = new System.Drawing.Point(459, 77);
            this.textBoxCheckMessage.Multiline = true;
            this.textBoxCheckMessage.Name = "textBoxCheckMessage";
            this.textBoxCheckMessage.Size = new System.Drawing.Size(328, 242);
            this.textBoxCheckMessage.TabIndex = 12;
            // 
            // MainPageAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 449);
            this.Controls.Add(this.textBoxCheckMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxUserData);
            this.Controls.Add(this.radioButtonConfrim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIDUser);
            this.Controls.Add(this.label1);
            this.Name = "MainPageAdministration";
            this.Text = "MainPageAdministration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonConfrim;
        public System.Windows.Forms.ListBox listBoxUserData;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxCheckMessage;
    }
}