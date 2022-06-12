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
        private LoginController loginController;
        private Staff currentUser;
        private Management management;
        private OrderScreenParent orderScreenParent;
        private BillController billController;
        private Tablet tablet;
        public LoginScreen(LoginScherm mainForm)
        {
            billController = new BillController();
            management = new Management(this);
            this.mainForm = mainForm;
            InitializeComponent();
        }

        //inloggen van user
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
                mainForm.Visible = false;
                OpenScreens();
            }
            else
            {
                MessageBox.Show("Combinatie van username en password is onbekend, probeer opniew.");
            }
        }

        //openen van childform wachtwoord vergeten
        private void lblWachtwoordVergeten_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new WachtwoordVergetenScreen(), sender);
        }

        //het uitloggen van de user
        public void Logout()
        {
            tablet.Hide();
            orderScreenParent.Hide();
            management.Hide();
            mainForm.Visible = true;
            ClearFields();
        }

        //maakt de velden leeg
        private void ClearFields()
        {
            txtBoxPassword.Text = null;
            txtBoxUsername.Text = null;
        }

        //het opnene van de verschillende schermen na inloggen
        private void OpenScreens()
        {
            tablet = new Tablet(currentUser, this);
            orderScreenParent = new OrderScreenParent(billController, currentUser, this);
            orderScreenParent.Show();
            management.Show();
            tablet.Show();
        }
    }
}
