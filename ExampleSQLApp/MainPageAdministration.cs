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
            buttonAutorization.Enabled = false;
            buttonGetMessage.Enabled = false;
        }
        // При нажатии на кнопку, перезаписывает данные о пользователе, с указанием на то что он теперь авторизован и может заходить
        // в личный кабинет.
        private void buttonAutorization_Click(object sender, EventArgs e)
        {
            IDSetButton.Enabled = true;
            AutoPassClilck.Enabled = true;
            User user = new User();
            UserDAO userDAO = new UserDAO();

            if (textBoxIDUser.Text == "")
                MessageBox.Show("В подтверждении отказано");
            else
            {
                user = userDAO.LoadUser(int.Parse(textBoxIDUser.Text));
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


        }


        // При нажатии на кнопку , перезаписывает данные о пользователе, с указанием на измененный ID
        private void IDSetButton_Click(object sender, EventArgs e)
        {
            IDSetButton.Enabled = false;
            buttonAutorization.Enabled = true;
            UserDAO userDAO = new UserDAO();
            User user = userDAO.LoadUser(1);
            user.ID = int.Parse(textBoxIDUser.Text);
            List<User> users = userDAO.LoadAllUser();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].ID == user.ID)
                {
                    MessageBox.Show("Такой ID Уже существует в базе");
                    break;
                }
                else if (textBoxIDUser.Text != "" && IsdigitOrSymbol(textBoxIDUser.Text) == false)
                {
                    users.Add(user);
                    for (int j = 0; i < users.Count; i++)
                    {
                        if (users[j].ID == 1)
                            users.RemoveAt(j);
                    }
                    userDAO.SaveAllUsers(users);
                }
                else
                    MessageBox.Show("Введите ID");
            }


        }
        //Вывод данные о не загестрированном пользователе, и присваивает ему ID, который выбирает Администратор
        private void AutoPassClilck_Click(object sender, EventArgs e)
        {
            AutoPassClilck.Enabled = false;
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
            listBoxUserData.DataSource = list;
        }
        //Выводит на экран данные о пользователе, поиск происходит по ID
        private void IDFinderbutton1_Click(object sender, EventArgs e)
        {
            if (textBoxGetUser.Text != "" && IsdigitOrSymbol(textBoxGetUser.Text) == false)
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
                listBoxUserData.DataSource = list;
            }
            else
                MessageBox.Show("Проверьте правильность введенных данных");
        }

        // Кнопка выхода из окна Администратора
        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }


        // При нажатии кнопки,в файл записывается сообщение, если оно подтверждено Администратором 
        private void buttonGetMessage_Click(object sender, EventArgs e)
        {
            textBoxCheckMessage.Text = "";
            buttonCheckMess.Enabled = true;
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
        // При нажатии кнопки, отображается последнее неподтвержденное письмо
        private void buttonCheckMess_Click(object sender, EventArgs e)
        {
            buttonCheckMess.Enabled = false;
            buttonGetMessage.Enabled = true;
            Messages messages = new Messages();
            messages.MessagesReader();
            foreach (var oneMess in messages.AllMessages)
            {
                textBoxCheckMessage.Text = oneMess.UserId + "\t" + oneMess.ThemeMessage + "\t" + oneMess.Text;

            }

        }
        // Визуальная составляющая формы
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

        public bool IsdigitOrSymbol(string str)
        {
            foreach (char ch in str)
            {
                if (Char.IsDigit(ch) || Char.IsControl(ch))
                { return false; }
            }
            return true;
        }
    }  
}
