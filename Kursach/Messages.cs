using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Kursach
{
    public class Messages
    {
        List<Message> allMessages = new List<Message>();

        public List<Message> AllMessages => allMessages;

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
            oneMessage.ThemeMessage = oneLine[1];
            oneMessage.Text = oneLine[2];

            if (oneLine.Length > 3)
            {
                oneMessage.EmployeeAnswer = oneLine[3];
            }

            return oneMessage;
        }
    }
}