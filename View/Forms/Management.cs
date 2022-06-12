﻿using System;
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
    public partial class Management : Form
    {
        private Form activeForm;
        private LoginScreen loginScreen;
        
        public Management(LoginScreen loginScreen)
        {
            this.loginScreen = loginScreen; 
            InitializeComponent();
        }
        private void Management_Load(object sender, EventArgs e)
        {
            OpenChildForm(new ManagementScreens.OverviewManagement(this), sender);
        }
        //Open child form
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
        //Back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagementScreens.OverviewManagement(this), sender);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            loginScreen.Logout();
        }
    }
}
