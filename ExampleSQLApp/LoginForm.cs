using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;
using Kursach;
using KursachVladdd;

namespace ExampleSQLApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            userFiled.ForeColor = Color.Gray;
            userFiled.Text = "Логин";

            passField.ForeColor = Color.Gray;
            passField.Text = "Пароль";

            passField.AutoSize = false;
            passField.Size = new Size(this.passField.Size.Width, 32);
            RegistorClick.ForeColor = Color.Gray;

        }



        private void enterButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            UserDAO userDAO = new UserDAO();
            /* Зайти за Админа */
            Administration administrator = new Administration();
            Employee employee = new Employee();
            if (userFiled.Text == administrator.Login && passField.Text == administrator.PassWord)
            {
                MainPageAdministration mainPageAdministration = new MainPageAdministration();
                this.Hide();
                mainPageAdministration.Show();

            }
            /*Зайти за Депутата*/
            else if (userFiled.Text == employee.Login && passField.Text == employee.Password)
            {
                MainPageEmployee pageEmployee = new MainPageEmployee();
                this.Hide();
                pageEmployee.Show();
            }
            /* Зайти за Одного из пользователей */
            else
            {
                List<User> users = userDAO.LoadAllUser();
                bool check = false;
                for (int i = 0; i < users.Count; i++)  // проходим по всему списку пользователей, находим того чьи Логин и пароль совпадают
                {                                      // Переходим на страницу пользователя, так же показываем его данные.
                    if (users[i].Login == userFiled.Text && users[i].PassWord.ToString() == passField.Text && users[i].Confirmed == true)
                    {
                        userFiled.BackColor = Color.White;
                        userFiled.BackColor = Color.White;
                        MainPageUser mainPageUser = new MainPageUser();
                        mainPageUser.listBoxUserLK.Items.Add("Имя: " + users[i].Name);
                        mainPageUser.listBoxUserLK.Items.Add("Фамилия: " + users[i].SurName);
                        mainPageUser.listBoxUserLK.Items.Add("Отчество: " + users[i].Patronimyc);
                        mainPageUser.listBoxUserLK.Items.Add("День рождения: " + users[i].Birthday);
                        mainPageUser.listBoxUserLK.Items.Add("Место жительства: " + users[i].Location);
                        mainPageUser.listBoxUserLK.Items.Add("Логин: " + users[i].Login);
                        mainPageUser.listBoxUserLK.Items.Add(users[i].ID);
                        this.Hide();
                        mainPageUser.Show();
                        check = true;
                        break;
                    }
                    else if (users[i].Login == userFiled.Text && users[i].PassWord.ToString() == passField.Text && users[i].Confirmed == false)
                    { // если пользователь зарегестрировался, но еще не подтверждён
                        check = true;
                        MessageBox.Show("Ожидайте подтверждение регистрации");
                        break;
                    }

                }
                if (check == false)
                { // Если введены неправльно введены логин или пароль
                    MessageBox.Show("Проверьте правильность введённых данных");
                }

            }


        }

        private void RegistorClick_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            RegisterForm registerForm1 = new RegisterForm();
            registerForm1.Show();
            registerForm1.RegisterButton.Focus();
        } // Переход на форму регистрации
        // Визуальная часть формы.
        private void userFiled_Enter(object sender, EventArgs e)
        {
            if (userFiled.Text == "Логин")
            {
                userFiled.Text = "";
                userFiled.ForeColor = Color.Black;
            }

        }

        private void userFiled_Leave(object sender, EventArgs e)
        {
            if (userFiled.Text == "")
            {
                userFiled.Text = "Логин";
                userFiled.ForeColor = Color.Gray;
            }

        }

        private void passField_Enter(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = true;
            if (passField.Text == "Пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }

        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.UseSystemPasswordChar = false;
                passField.Text = "Пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
                passField.UseSystemPasswordChar = false;
            else
                passField.UseSystemPasswordChar = true;
        } // при нажатии на чек бокс, отображается или  
    }    // не отображается пароль.
}
