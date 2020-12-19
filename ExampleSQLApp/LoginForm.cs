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
            if (userFiled.Text == "Admin" && passField.Text == "9999")
            {
                MainPageAdministration mainPageAdministration = new MainPageAdministration();
                this.Hide();
                mainPageAdministration.Show();

            }
            else
            {
                MainPageUser mainPageUser = new MainPageUser();
                this.Hide();
                mainPageUser.Show();
            }


        }

        private void RegistorClick_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            RegisterForm registerForm1 = new RegisterForm();
            registerForm1.Show();
            registerForm1.RegisterButton.Focus();
        }

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
        }
    }
}
