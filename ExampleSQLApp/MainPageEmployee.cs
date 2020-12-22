using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach;

namespace ExampleSQLApp
{
    public partial class MainPageEmployee : Form
    {
        public MainPageEmployee()
        {
           
            InitializeComponent();
            List<string> themQestions = new List<string>()
            {
                "Вопросы о ЖКХ",
                "Вопросы о дворовых зонах",
                "Вопросы о зонах отдыха",
                "Вопросы о льготных начислениях",
            };
            comboBoxMessageList.DataSource = themQestions;
            comboBoxMessageList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        // Отображает дополнтиельные данные о выбранном письме.
        private void listBoxLookMessages_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            messages.MessagesReader();
            if (listBoxLookMessages.Items.Count > 0)
            {
                for (int i = 0; i < messages.AllMessages.Count; i++)
                {
                    if (listBoxLookMessages.SelectedItem.ToString() == messages.AllMessages[i].Text)
                    {
                        textBoxLookMessage.Text = messages.AllMessages[i].UserId + " " + messages.AllMessages[i].Text;
                    }
                }
            }
            else 
            {
                MessageBox.Show("Обновите список");
            }
        }
        // Отображает все вопросы по выбранной теме.
        private void buttonCheckMess_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            messages.MessagesReader();
            for (int i = 0; i < messages.AllMessages.Count; i++)
            {
                if (comboBoxMessageList.SelectedItem.ToString() == messages.AllMessages[i].ThemeMessage && messages.AllMessages[i].MessConfirmed == true && messages.AllMessages[i].EmployeeAnswer == "---")
                    listBoxLookMessages.Items.Add( messages.AllMessages[i].Text);
            }
        }
        //Записывает ответ  на выбранный вопрос.
        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            messages.MessagesReader();
            if (textBoxAnswerMessage.Text != "")
            {
                for (int i = 0; i < messages.AllMessages.Count; i++)
                {
                    if (listBoxLookMessages.SelectedItem.ToString() == messages.AllMessages[i].Text)
                    {
                        messages.AllMessages[i].EmployeeAnswer = textBoxAnswerMessage.Text;
                        MessageBox.Show("Ответ отправлен");
                    }
                }
                messages.AllMessagesWriter(messages.AllMessages);
            }
            else
            {
                MessageBox.Show("Введите ответ");
            }
        }
        // Выходит из окна работника.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
