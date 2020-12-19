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

        }


  
        private void IDSetButton_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            User user = userDAO.LoadUser(1);
            int count = 100;
            user.ID = count;
            count++;
        }

        private void AutoPassClilck_Click(object sender, EventArgs e)
        {
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

        }
    }  
}
