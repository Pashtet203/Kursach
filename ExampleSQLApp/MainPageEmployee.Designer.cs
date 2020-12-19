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
            this.textBoxAnswerMessage = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.comboBoxMessageList = new System.Windows.Forms.ComboBox();
            this.buttonComeBack = new System.Windows.Forms.Button();
            this.listBoxLookMessages = new System.Windows.Forms.ListBox();
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
            this.textBoxAnswerMessage.Location = new System.Drawing.Point(367, 105);
            this.textBoxAnswerMessage.Multiline = true;
            this.textBoxAnswerMessage.Name = "textBoxAnswerMessage";
            this.textBoxAnswerMessage.Size = new System.Drawing.Size(236, 264);
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
            // 
            // comboBoxMessageList
            // 
            this.comboBoxMessageList.FormattingEnabled = true;
            this.comboBoxMessageList.Location = new System.Drawing.Point(124, 67);
            this.comboBoxMessageList.Name = "comboBoxMessageList";
            this.comboBoxMessageList.Size = new System.Drawing.Size(479, 21);
            this.comboBoxMessageList.TabIndex = 8;
            // 
            // buttonComeBack
            // 
            this.buttonComeBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonComeBack.BackgroundImage")));
            this.buttonComeBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonComeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComeBack.Location = new System.Drawing.Point(125, 105);
            this.buttonComeBack.Name = "buttonComeBack";
            this.buttonComeBack.Size = new System.Drawing.Size(26, 26);
            this.buttonComeBack.TabIndex = 10;
            this.buttonComeBack.UseVisualStyleBackColor = true;
            this.buttonComeBack.Click += new System.EventHandler(this.buttonComeBack_Click);
            // 
            // listBoxLookMessages
            // 
            this.listBoxLookMessages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxLookMessages.FormattingEnabled = true;
            this.listBoxLookMessages.Location = new System.Drawing.Point(125, 131);
            this.listBoxLookMessages.Name = "listBoxLookMessages";
            this.listBoxLookMessages.Size = new System.Drawing.Size(236, 238);
            this.listBoxLookMessages.TabIndex = 11;
            this.listBoxLookMessages.Click += new System.EventHandler(this.listBoxLookMessages_Click);
            // 
            // MainPageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 498);
            this.Controls.Add(this.listBoxLookMessages);
            this.Controls.Add(this.buttonComeBack);
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
        private System.Windows.Forms.Button buttonComeBack;
        private System.Windows.Forms.ListBox listBoxLookMessages;
    }
}