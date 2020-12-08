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
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            MainPageAdministration main = new MainPageAdministration();
            this.Hide();
            main.Show();
        }
    }
}
