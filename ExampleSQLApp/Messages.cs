using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Kursach
{
    public class Messages
    {
        private bool messageConfirmed;
        List<Message> allMessages = new List<Message>();

        public List<Message> AllMessages
        {
            get => allMessages;
            //set => allMessages = value;
        }

        public void MessagesReader()
        {
            foreach (string line in File.ReadLines("DataBaseMessages.txt"))
            {
                allMessages.Add(GetMessage(line));
            }
        }

        public Message GetMessage(string str)
        {
            string[] oneLine = str.Split('/');
            Message oneMessage = new Message();

            oneMessage.UserId = int.Parse(oneLine[0]);
            oneMessage.MessConfirmed = bool.Parse(oneLine[1]);
            oneMessage.ThemeMessage = oneLine[2];
            oneMessage.Text = oneLine[3];
            oneMessage.EmployeeAnswer = oneLine[4];
            oneMessage.Refusal = oneLine[5];

            return oneMessage;
        }

        public void MessageWriter(int id,bool confrim, string theme, string text,string answer,string refusal)
        {
            File.AppendAllText("DataBaseMessages.txt", id + "/"+ messageConfirmed + "/" + theme + "/" + text +"/" + answer +"/" + refusal);
        }

        public void AllMessagesWriter(List<Message> messages)
        {
            File.Delete("DataBaseMessages.txt");
            for (int i = 0; i < messages.Count; i++)
            {
                File.AppendAllText("DataBaseMessages.txt", messages[i].UserId.ToString()+"/"+messages[i].MessConfirmed.ToString()+"/"+messages[i].ThemeMessage+"/"+messages[i].Text + "/" +messages[i].EmployeeAnswer+ "/" + messages[i].Refusal + "\n");
            }
        }
    }
}