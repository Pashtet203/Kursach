namespace ExampleSQLApp
{
    partial class MainPageEmployee
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
            this.textBoxAnswerMessage = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.comboBoxMessageList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 450);
            this.label1.TabIndex = 5;
            // 
            // textBoxAnswerMessage
            // 
            this.textBoxAnswerMessage.Location = new System.Drawing.Point(124, 105);
            this.textBoxAnswerMessage.Multiline = true;
            this.textBoxAnswerMessage.Name = "textBoxAnswerMessage";
            this.textBoxAnswerMessage.Size = new System.Drawing.Size(479, 268);
            this.textBoxAnswerMessage.TabIndex = 6;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(528, 379);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.sendMessageButton.TabIndex = 7;
            this.sendMessageButton.Text = "Отправить";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // comboBoxMessageList
            // 
            this.comboBoxMessageList.FormattingEnabled = true;
            this.comboBoxMessageList.Location = new System.Drawing.Point(124, 67);
            this.comboBoxMessageList.Name = "comboBoxMessageList";
            this.comboBoxMessageList.Size = new System.Drawing.Size(479, 21);
            this.comboBoxMessageList.TabIndex = 8;
            // 
            // MainPageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 449);
            this.Controls.Add(this.comboBoxMessageList);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.textBoxAnswerMessage);
            this.Controls.Add(this.label1);
            this.Name = "MainPageEmployee";
            this.Text = "MainPageEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAnswerMessage;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.ComboBox comboBoxMessageList;
    }
}