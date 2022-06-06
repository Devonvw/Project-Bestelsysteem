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
using System.Runtime.InteropServices;
using Model;

namespace View.Forms
{
    public partial class Tablet : Form
    {
        private Form activeForm;
        private BillController billController;
        private Staff currentUser;
        public Tablet(Staff currentUser)
        {
            billController = new BillController();
            InitializeComponent();
            this.currentUser = currentUser;

            OrderScreenParent orderScreenParent = new OrderScreenParent(billController, currentUser);
            orderScreenParent.Show();

            Management management = new Management();
            management.Show();
        }
        // option to drag the screen by topPanel (eigk alleen voor gebruik op pc handig ofcourse maar werkt lekker tijdens developen)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Reservering_Load(object sender, EventArgs e)
        {
            OpenChildForm(new ReservationScreen(this, billController, currentUser), sender);
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
            OpenChildForm(new ReservationScreen(this, billController, currentUser), sender);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
