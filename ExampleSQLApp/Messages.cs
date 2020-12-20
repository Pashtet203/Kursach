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
            

            if (oneLine.Length > 3)
            {
                oneMessage.EmployeeAnswer = oneLine[3];
            }

            return oneMessage;
        }

        public void MessageWriter(int id,bool confrim, string theme, string text)
        {
            File.AppendAllText("DataBaseMessages.txt", id + "/"+ messageConfirmed + "/" + theme + "/" + text  +"\n");
        }
    }
}