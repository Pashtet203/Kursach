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

            comboBoxMessageList.DataSource = themQestions;
            comboBoxMessageList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        private void listBoxLookMessages_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            messages.MessagesReader(); 
                for (int i = 0; i < messages.AllMessages.Count; i++)
                {
                    if (listBoxLookMessages.SelectedItem.ToString() == messages.AllMessages[i].Text)
                    {
                        textBoxLookMessage.Text = messages.AllMessages[i].UserId + " " + messages.AllMessages[i].Text;
                    }
                }
            listBoxLookMessages.Items.Clear();
        }
        
        private void buttonComeBack_Click(object sender, EventArgs e)
        {
            ////listBoxLookMessages.ClearSelected();
            //Messages messages = new Messages();
            //messages.MessagesReader();
            buttonCheckMess_Click(sender, e);
           // listBoxLookMessages.DataSource = messages.AllMessages.ToString();
           textBoxLookMessage.Text = "";
        }

        private void buttonCheckMess_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            messages.MessagesReader();
            for (int i = 0; i < messages.AllMessages.Count; i++)
            {
                if (comboBoxMessageList.SelectedItem.ToString() == messages.AllMessages[i].ThemeMessage && messages.AllMessages[i].MessConfirmed == true)
                    listBoxLookMessages.Items.Add( messages.AllMessages[i].Text);
            }
        }
    }
}
