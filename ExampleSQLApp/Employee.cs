namespace Kursach
{
    public class Employee
    {
        private string login = "Employee";
        private string password = "8888";


        public string Login
        {
            get => login;
            set => login = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

    }
}