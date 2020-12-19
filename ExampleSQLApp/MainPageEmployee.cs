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

namespace ExampleSQLApp
{
    public partial class MainPageEmployee : Form
    {
        List<string> allMess = new List<string>() { "Тестовое письмо1", "Тестовое письмо2" };
        public MainPageEmployee()
        {
           
            InitializeComponent();
            List<string> themQestions = new List<string>()
            {
                "Вопросы о ЖКХ",
                "Вопросы о дворовых зонах",
                "Вопросы о зонах отдыха",
                "Вопросы о льготных начислениях",
            };

            listBoxLookMessages.DataSource = allMess;
            Messages mess = new Messages();
        }
        private void listBoxLookMessages_Click(object sender, EventArgs e)
        {
            listBoxLookMessages.ClearSelected();
            List<string> temp = new List<string>() {"Вложение 1","Вложение 2"};
            listBoxLookMessages.DataSource = temp;
        }
        
        private void buttonComeBack_Click(object sender, EventArgs e)
        {
            listBoxLookMessages.ClearSelected();
            listBoxLookMessages.DataSource = allMess;
        }
    }
}
