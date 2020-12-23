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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLookMessage = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.comboBoxMessageList = new System.Windows.Forms.ComboBox();
            this.listBoxLookMessages = new System.Windows.Forms.ListBox();
            this.buttonCheckMess = new System.Windows.Forms.Button();
            this.textBoxAnswerMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // textBoxLookMessage
            // 
            this.textBoxLookMessage.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLookMessage.Location = new System.Drawing.Point(272, 105);
            this.textBoxLookMessage.Multiline = true;
            this.textBoxLookMessage.Name = "textBoxLookMessage";
            this.textBoxLookMessage.Size = new System.Drawing.Size(331, 101);
            this.textBoxLookMessage.TabIndex = 6;
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
            this.comboBoxMessageList.Size = new System.Drawing.Size(435, 21);
            this.comboBoxMessageList.TabIndex = 8;
            this.comboBoxMessageList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxMessageList_MouseClick);
            // 
            // listBoxLookMessages
            // 
            this.listBoxLookMessages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxLookMessages.FormattingEnabled = true;
            this.listBoxLookMessages.Location = new System.Drawing.Point(124, 111);
            this.listBoxLookMessages.Name = "listBoxLookMessages";
            this.listBoxLookMessages.Size = new System.Drawing.Size(141, 264);
            this.listBoxLookMessages.TabIndex = 11;
            this.listBoxLookMessages.Click += new System.EventHandler(this.listBoxLookMessages_Click);
            // 
            // buttonCheckMess
            // 
            this.buttonCheckMess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCheckMess.BackgroundImage")));
            this.buttonCheckMess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCheckMess.Location = new System.Drawing.Point(565, 67);
            this.buttonCheckMess.Name = "buttonCheckMess";
            this.buttonCheckMess.Size = new System.Drawing.Size(37, 23);
            this.buttonCheckMess.TabIndex = 12;
            this.buttonCheckMess.UseVisualStyleBackColor = true;
            this.buttonCheckMess.Click += new System.EventHandler(this.buttonCheckMess_Click);
            // 
            // textBoxAnswerMessage
            // 
            this.textBoxAnswerMessage.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.textBoxAnswerMessage.Location = new System.Drawing.Point(273, 213);
            this.textBoxAnswerMessage.Multiline = true;
            this.textBoxAnswerMessage.Name = "textBoxAnswerMessage";
            this.textBoxAnswerMessage.Size = new System.Drawing.Size(330, 162);
            this.textBoxAnswerMessage.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.button1.Location = new System.Drawing.Point(639, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainPageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAnswerMessage);
            this.Controls.Add(this.buttonCheckMess);
            this.Controls.Add(this.listBoxLookMessages);
            this.Controls.Add(this.comboBoxMessageList);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.textBoxLookMessage);
            this.Controls.Add(this.label1);
            this.Name = "MainPageEmployee";
            this.Text = "MainPageEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLookMessage;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.ComboBox comboBoxMessageList;
        private System.Windows.Forms.ListBox listBoxLookMessages;
        private System.Windows.Forms.Button buttonCheckMess;
        private System.Windows.Forms.TextBox textBoxAnswerMessage;
        private System.Windows.Forms.Button button1;
    }
}