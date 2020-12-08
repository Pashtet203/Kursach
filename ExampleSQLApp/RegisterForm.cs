using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            RegistrationNameField.Text = "Имя";
            RegistrationNameField.ForeColor = Color.Gray;

            RegistrationSurnameField.Text = "Фамилия";
            RegistrationSurnameField.ForeColor = Color.Gray;

            RegistrationPatronymicField.Text = "Отчество";
            RegistrationPatronymicField.ForeColor = Color.Gray;

            RegistrationDateOfBrithdayField.Text = "Дата рождения";
            RegistrationDateOfBrithdayField.ForeColor = Color.Gray;

            RegistrationLocationField.Text = "Место жительства";
            RegistrationLocationField.ForeColor = Color.Gray;

            textBoxLogin.Text = "Логин";
            textBoxLogin.ForeColor = Color.Gray;

            textBoxPassword.Text = "Пароль";
            textBoxPassword.ForeColor = Color.Gray;

            textBoxConfrimPass.Text = "Подтвердите пароль";
            textBoxConfrimPass.ForeColor = Color.Gray;

            textBoxPassword.UseSystemPasswordChar = true;
        }


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            //this.Hide();
            //loginForm.Show();
            MainPageAdministration mainPageAdministration = new MainPageAdministration();

           mainPageAdministration.listBoxUserData.Items.Add("Логин: " + this.textBoxLogin.Text);
           mainPageAdministration.listBoxUserData.Items.Add("Имя: " + this.RegistrationNameField.Text);
           mainPageAdministration.listBoxUserData.Items.Add("Фамилия: " + this.RegistrationSurnameField.Text);
           mainPageAdministration.listBoxUserData.Items.Add("Отчество: " + this.RegistrationPatronymicField.Text);
           mainPageAdministration.listBoxUserData.Items.Add("Дата рождения: " + this.RegistrationDateOfBrithdayField.Text);
           mainPageAdministration.listBoxUserData.Items.Add("Место жительства: " + this.RegistrationLocationField.Text);
            this.Hide();
            mainPageAdministration.Show();
        }

        private void RegistrationSurnameFiled_Enter(object sender, EventArgs e)
        {
            if (RegistrationSurnameField.Text == "Фамилия")
            {
                RegistrationSurnameField.Text = "";
                RegistrationSurnameField.ForeColor = Color.Black;
            }
                

        }

        private void RegistrationSurnameFiled_Leave(object sender, EventArgs e)
        {
            if (RegistrationSurnameField.Text == "")
            {
                RegistrationSurnameField.Text = "Фамилия";
                RegistrationSurnameField.ForeColor = Color.Gray;
            }
        }

        private void RegistrationNameFiled_Enter(object sender, EventArgs e)
        {
            if (RegistrationNameField.Text == "Имя")
            {
                RegistrationNameField.Text = "";
                RegistrationNameField.ForeColor = Color.Black;
            }
                
        }

        private void RegistrationNameFiled_Leave(object sender, EventArgs e)
        {
            if (RegistrationNameField.Text == "")
            {
                RegistrationNameField.Text = "Имя";
                RegistrationNameField.ForeColor = Color.Gray;
            }
                
        }

        private void RegistrationPatronymicField_Enter(object sender, EventArgs e)
        {
            if (RegistrationPatronymicField.Text == "Отчество")
            {
                RegistrationPatronymicField.Text = "";
                RegistrationPatronymicField.ForeColor = Color.Black;
            }
                
        }

        private void RegistrationPatronymicField_Leave(object sender, EventArgs e)
        {
            if (RegistrationPatronymicField.Text == "")
            {
                RegistrationPatronymicField.Text = "Отчество";
                RegistrationPatronymicField.ForeColor = Color.Gray;
            }
                
        }

        private void RegistrationDateOfBrithdayField_Enter(object sender, EventArgs e)
        {
            if (RegistrationDateOfBrithdayField.Text == "Дата рождения")
            {
                RegistrationDateOfBrithdayField.Text = "";
                RegistrationDateOfBrithdayField.ForeColor = Color.Black;
            }
                
        }

        private void RegistrationDateOfBrithdayField_Leave(object sender, EventArgs e)
        {
            if (RegistrationDateOfBrithdayField.Text == "")
            {
                RegistrationDateOfBrithdayField.Text = "Дата рождения";
                RegistrationDateOfBrithdayField.ForeColor = Color.Gray;
            }
                
        }

        private void RegistrationLocationField_Enter(object sender, EventArgs e)
        {
            if (RegistrationLocationField.Text == "Место жительства")
            {
                RegistrationLocationField.Text = "";
                RegistrationLocationField.ForeColor = Color.Black;
            }
                
        }
        private void RegistrationLocationField_Leave(object sender, EventArgs e)
        {
            if (RegistrationLocationField.Text == "")
            {
                RegistrationLocationField.Text = "Место жительства";
                RegistrationLocationField.ForeColor = Color.Gray;
            }
                
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Логин")
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }    
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = "Логин";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Пароль")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }    
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Пароль";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxConfrimPass_Enter(object sender, EventArgs e)
        {
            if (textBoxConfrimPass.Text == "Подтвердите пароль")
            {
                textBoxConfrimPass.Text = "";
                textBoxConfrimPass.ForeColor = Color.Black;
            }    
        }

        private void textBoxConfrimPass_Leave(object sender, EventArgs e)
        {
            if (textBoxConfrimPass.Text == "")
            {
                textBoxConfrimPass.Text = "Подтвердите пароль";
                textBoxConfrimPass.ForeColor = Color.Gray;
            }
        }
    }
}
