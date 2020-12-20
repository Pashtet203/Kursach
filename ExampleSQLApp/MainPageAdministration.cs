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

namespace ExampleSQLApp
{
    public partial class MainPageAdministration : Form
    {
        public MainPageAdministration()
        {
            InitializeComponent();
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

    }  
}
