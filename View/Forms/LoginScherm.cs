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
    public partial class LoginScherm : Form
    {
        private Form activeForm;
        public LoginScherm()
        {
            InitializeComponent();
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlChild.Controls.Add(childForm);
            this.pnlChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void LoginScherm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new LoginScreen(this), sender);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoginScreen(this), sender);
        }
    }
}
