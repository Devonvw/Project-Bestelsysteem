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
    public partial class WachtwoordVergetenScreen : Form
    { 
        public WachtwoordVergetenScreen()
        {
            InitializeComponent();
        }

        private void btnHerstelWachtwoord_Click(object sender, EventArgs e)
        {
            string email = txtBoxEmail.Text;
            
            LoginController loginController = new LoginController();
            List<Login> allUsers = loginController.GetAllUsers();
            if(EmailIsKnown(allUsers, email))
            {
                MessageBox.Show($"Er is een email gestuurd naar {email.ToLower()}, via deze mail kan u uw wachtwoord opnieuw instellen");
            }
            else
            {
                MessageBox.Show("Het opgegeven email adres is niet bekend bij ons, controleer uw email adres en probeer het opnieuw");
            }
        }
        private bool EmailIsKnown(List <Login> allUsers, string email)
        {
            foreach (Login l in allUsers)
            {
                if (l.UserName.ToLower() == email.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
