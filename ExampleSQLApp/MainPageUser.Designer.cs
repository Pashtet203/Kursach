﻿namespace ExampleSQLApp
{
    partial class MainPageUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageUser));
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.messageFiled = new System.Windows.Forms.TextBox();
            this.comboBoxThemQuestions = new System.Windows.Forms.ComboBox();
            this.buttonExitLK = new System.Windows.Forms.Button();
            this.listBoxUserLK = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(528, 386);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.sendMessageButton.TabIndex = 2;
            this.sendMessageButton.Text = "Отправить";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(758, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 450);
            this.label1.TabIndex = 4;
            // 
            // messageFiled
            // 
            this.messageFiled.Location = new System.Drawing.Point(124, 112);
            this.messageFiled.Multiline = true;
            this.messageFiled.Name = "messageFiled";
            this.messageFiled.Size = new System.Drawing.Size(479, 268);
            this.messageFiled.TabIndex = 5;
            // 
            // comboBoxThemQuestions
            // 
            this.comboBoxThemQuestions.FormattingEnabled = true;
            this.comboBoxThemQuestions.Location = new System.Drawing.Point(124, 74);
            this.comboBoxThemQuestions.Name = "comboBoxThemQuestions";
            this.comboBoxThemQuestions.Size = new System.Drawing.Size(479, 21);
            this.comboBoxThemQuestions.TabIndex = 7;
            // 
            // buttonExitLK
            // 
            this.buttonExitLK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExitLK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExitLK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.buttonExitLK.Location = new System.Drawing.Point(845, 386);
            this.buttonExitLK.Name = "buttonExitLK";
            this.buttonExitLK.Size = new System.Drawing.Size(75, 23);
            this.buttonExitLK.TabIndex = 8;
            this.buttonExitLK.Text = "Выход";
            this.buttonExitLK.UseVisualStyleBackColor = false;
            this.buttonExitLK.Click += new System.EventHandler(this.buttonExitLK_Click);
            // 
            // listBoxUserLK
            // 
            this.listBoxUserLK.FormattingEnabled = true;
            this.listBoxUserLK.Location = new System.Drawing.Point(715, 112);
            this.listBoxUserLK.Name = "listBoxUserLK";
            this.listBoxUserLK.Size = new System.Drawing.Size(205, 134);
            this.listBoxUserLK.TabIndex = 9;
            // 
            // MainPageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 449);
            this.Controls.Add(this.listBoxUserLK);
            this.Controls.Add(this.buttonExitLK);
            this.Controls.Add(this.comboBoxThemQuestions);
            this.Controls.Add(this.messageFiled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendMessageButton);
            this.Name = "MainPageUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox messageFiled;
        private System.Windows.Forms.ComboBox comboBoxThemQuestions;
        private System.Windows.Forms.Button buttonExitLK;
        public System.Windows.Forms.ListBox listBoxUserLK;
    }
}