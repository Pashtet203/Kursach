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
using KursachVladdd;

namespace ExampleSQLApp
{
    public partial class MainPageUser : Form
    {
        public MainPageUser()
        {
            InitializeComponent();

            List<string> themQestions = new List<string>()
            {
                "Вопросы о ЖКХ",
                "Вопросы о дворовых зонах",
                "Вопросы о зонах отдыха",
                "Вопросы о льготных начислениях",
            };
            comboBoxThemQuestions.DataSource = themQestions;
            comboBoxThemQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }


        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            User user = userDAO.LoadUser(int.Parse(listBoxUserLK.Items[6].ToString()));
            MainPageAdministration main = new MainPageAdministration();
            MessageBox.Show("Ваше письмо отправлено");
            Messages messages = new Messages();
            messages.MessageWriter(user.ID,false,comboBoxThemQuestions.SelectedItem.ToString(),messageFiled.Text);
            main.textBoxCheckMessage.Text = this.messageFiled.Text;
        }


        private void buttonExitLK_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
