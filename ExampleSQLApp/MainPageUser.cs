using System;
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
    public partial class MainPageUser : Form
    {
        public MainPageUser()
        {
            InitializeComponent();
            comboBoxThemQuestions.Text = "Выберете тему";
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

        private void comboBoxThemQuestions_Enter(object sender, EventArgs e)
        {
           
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            MainPageAdministration main = new MainPageAdministration();
            MessageBox.Show("Ваше письмо отправлено");
            main.textBoxCheckMessage.Text = this.messageFiled.Text;
            this.Hide();
            main.Show();
        }

        private void messageFiled_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
