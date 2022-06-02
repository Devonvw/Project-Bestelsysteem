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

namespace View.Forms
{
    public partial class Reservering : Form
    {
        private Form activeForm;
        private BillController billController;
        public Reservering()
        {
            billController = new BillController();
            InitializeComponent();

            BillScreen billScreen = new BillScreen(new Model.Table(1, true), billController);
            billScreen.Show();

            Management management = new Management();
            management.Show();
        }

        private void Reservering_Load(object sender, EventArgs e)
        {
            OpenChildForm(new ReservationScreen(this, billController), sender);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReservationScreen(this, billController), sender);
        }
    }
}
