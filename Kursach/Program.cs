using System;

namespace Kursach
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Message message =new Message();
            message.MessageWriter(123, "theme", "text");
            
            Messages messages = new Messages();
            messages.MessagesReader();
            foreach (var oneMessage in messages.AllMessages)
            {
                Console.WriteLine(oneMessage.UserId);
                Console.WriteLine(oneMessage.ThemeMessage);
                Console.WriteLine(oneMessage.Text);
                Console.WriteLine();
            }
        }
    }
}