using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Kursach
{
    public class Message
    {
        private int userID;
        private string themeMessage;
        private string textMessage;
        private string employeeAnswer = null;

        public int UserId
        {
            get => userID;
            set => userID = value;
        }

        public string ThemeMessage
        {
            get => themeMessage;
            set => themeMessage = value;
        }

        public string Text
        {
            get => textMessage;
            set => textMessage = value;
        }

        public string EmployeeAnswer
        {
            get => employeeAnswer;
            set => employeeAnswer = value;
        }

        public void MessageWriter(int id, string theme, string text)
        {
            File.AppendAllText("DataBaseMessages.txt", id + "/" + theme + "/" + text + "\n");
        }
        
        
    }
}