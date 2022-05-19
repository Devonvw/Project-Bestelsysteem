using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace View.Forms
{
    public partial class LoginScreen : Form
    {
        LoginController loginController;
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.UserName = txtBoxUsername.Text;
            login.Password = txtBoxPassword.Text;
            loginController.LoginCheck(login);
        }
    }
}
