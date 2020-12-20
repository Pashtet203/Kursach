using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KursachVladdd
{
    public class UserDAO
    {
        public List<User> LoadAllUser()
        {
            List<string> listTempUser = new List<string>();
            StreamReader sr = new StreamReader("FILE.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                listTempUser.Add(s);
            }
            
            List<User> user = new List<User>();
            for (int i = 0; i < listTempUser.Count; i+=9)
            {
                User u = new User();         
                u.Name = listTempUser[0+i];
                u.SurName = listTempUser[1 + i];
                u.Patronimyc = listTempUser[2 + i];
                u.Birthday = listTempUser[3 + i];
                u.Location = listTempUser[4 + i];
                u.Login = listTempUser[5 + i];
                u.PassWord = int.Parse(listTempUser[6 + i]);               
                u.ID =int.Parse( listTempUser[7 + i]);
                u.Confirmed =bool.Parse( listTempUser[8 + i]);
                user.Add(u);
            }
            sr.Close();
            return user;
        }
        public User LoadUser(int Id)
        {
            List<User> u= LoadAllUser();
            int posicion=-1;
            for(int i=0;i<u.Count;i++)
            {
                if(u[i].ID==Id)
                {
                    posicion = i;
                }
            }
            User e;
            if (posicion != -1)
                 e = u[posicion];
            else
                throw new Exception("A negative argument");
            return e;
        }
        public void SaveUser(User u)
        {
            //File.Delete("FILE.txt");
        File.AppendAllText("FILE.txt",
                u.Name + "\n" +
                u.SurName + "\n" +
                u.Patronimyc + "\n" +
                u.Birthday + "\n" +
                u.Location + "\n" +
                u.Login + "\n" +
                u.PassWord + "\n" +
                u.ID + "\n" +
                u.Confirmed + "\n");
        }

        public void SaveAllUsers(List<User> users)
        {
            File.Delete("FILE.txt");
            for (int i = 0; i < users.Count; i++)
            {
                File.AppendAllText("FILE.Txt",
                    users[i].Name + "\n" +
                    users[i].SurName + "\n" +
                    users[i].Patronimyc + "\n" +
                    users[i].Birthday + "\n" +
                    users[i].Location + "\n" +
                    users[i].Login + "\n" +
                    users[i].PassWord + "\n" +
                    users[i].ID + "\n" +
                    users[i].Confirmed + "\n");
            }
        }
    }
}
