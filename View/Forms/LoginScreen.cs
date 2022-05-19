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
        private Form activeForm;
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

        private void lblWachtwoordVergeten_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = new Forms.RequestPasswordScreen();
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;
            /*this.pnlForms.Controls.Add(childForm);
            this.pnlForms.Tag = childForm;*/
            activeForm.BringToFront();
            activeForm.Show();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            /*this.pnlForms.Controls.Add(childForm);
            this.pnlForms.Tag = childForm;*/
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
