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
using KursachVladdd;

namespace ExampleSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent(); // Инициализация полей при входе в форму.
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
            textBoxPassword.AutoSize = false;
            textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 33);

            textBoxConfrimPass.Text = "Подтвердите пароль";
            textBoxConfrimPass.ForeColor = Color.Gray;
            textBoxConfrimPass.AutoSize = false;
            textBoxConfrimPass.Size = new Size(this.textBoxConfrimPass.Size.Width, 33);
            panel1.Focus();
        }
        //При нажатии на кнопку зарегистрироваться, данные с полей формы записываются в Файл, который хранит юзеров.
       public void RegisterButton_Click(object sender, EventArgs e) 
        {
            MainPageAdministration mainPageAdministration = new MainPageAdministration();
            User u = new User();
            UserDAO us = new UserDAO();
            if (RegistrationNameField.Text != "Имя" && RegistrationSurnameField.Text != "Фамилия" && RegistrationPatronymicField.Text != "Отчетсво" && textBoxLogin.Text != "Логин" && RegistrationDateOfBrithdayField.Text != "Дата рождения" && RegistrationLocationField.Text != "Место жительства" && textBoxConfrimPass.Text != "Подтвердите пароль" && textBoxPassword.Text != "Пароль")
            {
                u.Name = RegistrationNameField.Text;
                u.SurName = RegistrationSurnameField.Text;
                u.Patronimyc = RegistrationPatronymicField.Text;
                u.Login = textBoxLogin.Text;
                u.PassWord = int.Parse(textBoxPassword.Text);
                u.Location = RegistrationLocationField.Text;
                u.Birthday = RegistrationDateOfBrithdayField.Text;
                u.ID = 1;
                us.SaveUser(u);
            }
            else
            {
                MessageBox.Show("Проверьте правильность введённых данных");
            }   
            if (textBoxPassword.Text == textBoxConfrimPass.Text) // Проверка на правильность подтверждения паролей.
            {
                MessageBox.Show("Ожидайте подтверждение регистрации в течении 5 минут.");
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
            else
            {
                MessageBox.Show("Проверьте правильность паролей");
            }

        }

        public bool IsdigitOrSymbol(string str)
        {
            foreach (char ch in str)
            {
                if (Char.IsDigit(ch) || Char.IsControl(ch))
                { return false; }
            }
            return true;
        } // метод проверяющий что в строке нет специальных символов.
        public bool ConfrimSymbol(string str)
        {
            foreach (char ch in str)
            {
                if (Char.IsLetter(ch))
                { return false; }
            }
            return true;
        }    // Метод проверяющий что в строке нет буквенных символов.
        private void RegistrationSurnameFiled_Enter(object sender, EventArgs e)
        {
            if (RegistrationSurnameField.Text == "Фамилия")
            {
                RegistrationSurnameField.Text = "";
                RegistrationSurnameField.ForeColor = Color.Black;
            }

        }
        // Визуальная составляющия формы.
        private void RegistrationSurnameFiled_Leave(object sender, EventArgs e)
        {
            if (RegistrationSurnameField.Text == "")
            {
                RegistrationSurnameField.Text = "Фамилия";
                RegistrationSurnameField.ForeColor = Color.Gray;
            }
            if (!IsdigitOrSymbol(RegistrationSurnameField.Text))
                RegistrationSurnameField.BackColor = Color.Crimson;
            else
                RegistrationSurnameField.BackColor = Color.White;

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
            if (!IsdigitOrSymbol(RegistrationNameField.Text))
                RegistrationNameField.BackColor = Color.Crimson;
            else
                RegistrationNameField.BackColor = Color.White;
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
            if (!IsdigitOrSymbol(RegistrationPatronymicField.Text))
                RegistrationPatronymicField.BackColor = Color.Crimson;
            else
                RegistrationPatronymicField.BackColor = Color.White;
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
            if (!ConfrimSymbol(RegistrationDateOfBrithdayField.Text))
                RegistrationDateOfBrithdayField.BackColor = Color.Crimson;
            else
                RegistrationDateOfBrithdayField.BackColor = Color.White;
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
            if (!IsdigitOrSymbol(RegistrationLocationField.Text))
                RegistrationLocationField.BackColor = Color.Crimson;
            else
                RegistrationLocationField.BackColor = Color.White;
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
            if (ConfrimSymbol(textBoxLogin.Text))
                textBoxLogin.BackColor = Color.Crimson;
            else
                textBoxLogin.BackColor = Color.White;
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
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
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.Text = "Пароль";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxConfrimPass_Enter(object sender, EventArgs e)
        {
            textBoxConfrimPass.UseSystemPasswordChar = true;
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

                textBoxConfrimPass.UseSystemPasswordChar = false;
                textBoxConfrimPass.Text = "Подтвердите пароль";
                textBoxConfrimPass.ForeColor = Color.Gray;
            }
            if (textBoxPassword.Text != textBoxConfrimPass.Text)
                textBoxConfrimPass.BackColor = Color.Crimson;
            else
                textBoxConfrimPass.BackColor = Color.White;
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void checkBoxPassConfrim_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassConfrim.Checked)
                textBoxConfrimPass.UseSystemPasswordChar = false;
            else
                textBoxConfrimPass.UseSystemPasswordChar = true;
        }
    }
}

