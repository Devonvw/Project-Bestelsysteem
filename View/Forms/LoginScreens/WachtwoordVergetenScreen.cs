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
            MessageBox.Show($"Er is een email gestuurd naar {email}, via deze mail kan u uw wachtwoord opnieuw instellen");
            //aanpassen --> hier verwijzen naar controller laag --> email sturen voor aanpassen wachtwoord 
            //--> aanpassen in databse / of manager een code geven --> die code invullen en dan wachtwoord aan kunnen passen. 
            //emailaddres staat in txtBoxEmail
        }
    }
}
