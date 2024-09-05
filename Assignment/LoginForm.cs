using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string UserName = usernamebox.Text;
            string Password = passwordbox.Text;

            if (UserName == "ayubo" && Password == "0000")
            {

                this.Hide();

                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Login Field !");
            }
        }
    }
}
