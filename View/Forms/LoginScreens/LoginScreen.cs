using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class LoginScreen : Form
    {
        private LoginScherm mainForm;
        LoginController loginController;
        private Staff currentUser;
        public LoginScreen(LoginScherm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginController = new LoginController();
            Login login = new Login();
            login.Password = txtBoxPassword.Text;
            login.UserName = txtBoxUsername.Text;
            bool validUser = loginController.LoginCheck(login);
            if (validUser)
            {
                StaffController staffController = new StaffController();
                Staff staff = new Staff();
                staff.Email = txtBoxUsername.Text;
                currentUser = staffController.GetStaffByEmail(staff);
                Tablet tablet = new Tablet(currentUser);
                tablet.Show();
            }
            else
            {
                MessageBox.Show("Combinatie van username en password is onbekend, probeer opniew.");
            }
        }
        private void lblWachtwoordVergeten_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new WachtwoordVergetenScreen(), sender);
        }
    }
}
