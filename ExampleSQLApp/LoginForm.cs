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
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 32);
            RegistorClick.ForeColor = Color.Gray;
        }



        private void enterButton_Click(object sender, EventArgs e)
        {
            MainPageUser mainPageUser = new MainPageUser();
            this.Hide();
            mainPageUser.Show();

        }

        private void RegistorClick_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            RegisterForm registerForm1 = new RegisterForm();
            registerForm1.Show();
        }
    }
}
