using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class BestelsysteemUI : Form
    {
        private Form activeForm;
        public BestelsysteemUI()
        {
            InitializeComponent();
            activeForm = new Forms.BillScreen();
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;
            this.pnlForms.Controls.Add(activeForm);
            this.pnlForms.Tag = activeForm;
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
            this.pnlForms.Controls.Add(childForm);
            this.pnlForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void orderScreenButton_Click(object sender, EventArgs e)
        {
            activeForm = new Forms.BillScreen();
        }
    }
}
