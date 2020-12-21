using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursachVladdd;
using Kursach;

namespace ExampleSQLApp
{
    public partial class MainPageAdministration : Form
    {
        public MainPageAdministration()
        {
            InitializeComponent();
            textBoxAnswerMess.Text = "Причина отказа в подтверждении сообщения";
            textBoxCheckMessage.ReadOnly = true;
            textBoxCheckMessage.BackColor = Color.White;


            //Messages mess = new Messages();
            //mess.MessagesReader();

        }

        private void buttonAutorization_Click(object sender, EventArgs e)
        {
            User user = new User();
            UserDAO userDAO = new UserDAO();
            user = userDAO.LoadUser(int.Parse(textBoxGetUser.Text));
            List<User> users = userDAO.LoadAllUser();
            if (radioButtonConfrim.Checked)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Confirmed == false)
                    {
                        user.Confirmed = true;
                        users.RemoveAt(i);
                        users.Insert(i, user);
                    }
                }
            }
            userDAO.SaveAllUsers(users);
        }


  
        private void IDSetButton_Click(object sender, EventArgs e)
        {
            
            UserDAO userDAO = new UserDAO();
            User user = userDAO.LoadUser(1);
            user.ID = int.Parse(textBoxIDUser.Text);
            List<User> users = userDAO.LoadAllUser();
            users.Add(user);
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].ID == 1)
                    users.RemoveAt(i);
            }  
            userDAO.SaveAllUsers(users);

        }

        private void AutoPassClilck_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            UserDAO userDAO = new UserDAO();
            User user = userDAO.LoadUser(1);
            List<string> list = new List<string>();
            list.Add("ID Пользователя: " + user.ID.ToString());
            list.Add("Имя: " + user.Name);
            list.Add("Фамилия: " + user.SurName);
            list.Add("Отчество: " + user.Patronimyc);
            list.Add("Дата рождения: " + user.Birthday);
            list.Add("Место жительства: " + user.Location);
            list.Add("Логин: " + user.Login);
            list.Add("Пароль: " + user.PassWord.ToString());
            listBoxUserData.DataSource = list;
        }

        private void IDFinderbutton1_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            User user = userDAO.LoadUser(int.Parse(textBoxGetUser.Text));
            List<string> list = new List<string>();
            list.Add("ID Пользователя: " + user.ID.ToString());
            list.Add("Имя: " + user.Name);
            list.Add("Фамилия: " + user.SurName);
            list.Add("Отчество: " + user.Patronimyc);
            list.Add("Дата рождения: " + user.Birthday);
            list.Add("Место жительства: " + user.Location);
            list.Add("Логин: " + user.Login);
            list.Add("Пароль: " + user.PassWord.ToString());
            listBoxUserData.DataSource = list;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }



        private void buttonGetMessage_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            messages.MessagesReader();
            List<Kursach.Message> messages1 = messages.AllMessages;
            Kursach.Message messageTemp = messages1[messages1.Count - 1];
                if (messageTemp.MessConfirmed == false && radioButtonConfirmMess.Checked)
                {
                    messages1[messages1.Count - 1].MessConfirmed = true;
                }
                else if (!radioButtonConfirmMess.Checked && messageTemp.MessConfirmed == false)
                {
                messages1[messages1.Count - 1].Refusal = "Причина отказа: " + textBoxAnswerMess.Text;
                }
            messages.AllMessagesWriter(messages1);
        }

        private void buttonCheckMess_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            messages.MessagesReader();
            foreach (var oneMess in messages.AllMessages)
            {
                textBoxCheckMessage.Text = oneMess.UserId + "\t" + oneMess.ThemeMessage + "\t" + oneMess.Text;

            }

        }

        private void textBoxAnswerMess_Enter(object sender, EventArgs e)
        {
            if (textBoxAnswerMess.Text == "Причина отказа в подтверждении сообщения")
                textBoxAnswerMess.Text = "";
        }

        private void textBoxAnswerMess_Leave(object sender, EventArgs e)
        {
            if (textBoxAnswerMess.Text == "")
                textBoxAnswerMess.Text = "Причина отказа в подтверждении сообщения";
        }
    }  
}
