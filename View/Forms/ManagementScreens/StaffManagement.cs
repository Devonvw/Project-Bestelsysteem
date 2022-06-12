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

namespace View.Forms.ManagementScreens
{
    public partial class StaffManagement : Form
    {
        private StaffController staffController;
        private List<Staff> staffList;
        private Staff selectedStaff;
        private void Reload()
        {
            staffList = staffController.GetAllStaff();
            ltvStaff.Items.Clear();
            staffList.ForEach(staff =>
            {
                ListViewItem listViewItem = new ListViewItem(staff.FirstName);
                listViewItem.SubItems.Add(staff.LastName);
                listViewItem.SubItems.Add(staff.BirthDate.ToString("dd-MM-yyyy"));
                listViewItem.SubItems.Add(staff.Role.ToString());
                listViewItem.SubItems.Add(staff.Email);
                listViewItem.SubItems.Add(staff.Employed ? "Ja" : "Nee");
                listViewItem.Tag = staff;
                ltvStaff.Items.Add(listViewItem);
            });
        }
        public StaffManagement()
        {
            staffController = new StaffController();
            InitializeComponent();
        }
        private void StaffManagement_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void ltvStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltvStaff.SelectedItems.Count > 0)
            {
                selectedStaff = (Staff)ltvStaff.SelectedItems[0].Tag;
                tbxFirstName.Text = selectedStaff.FirstName;
                tbxLastname.Text = selectedStaff.LastName;
                tbxEmail.Text = selectedStaff.Email;
                dtpBirthdate.Value = selectedStaff.BirthDate;
                cbxEmployed.Checked = selectedStaff.Employed;
                switch (selectedStaff.Role)
                {
                    case Roles.Manager:
                        rbtnManager.Checked = true;
                        break;
                    case Roles.Bartender:
                        rbtnBartender.Checked = true;
                        break;
                    case Roles.Waiter:
                        rbtnWaiter.Checked = true;
                        break;
                    case Roles.Chef:
                        rbtnChef.Checked = true;
                        break;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ltvStaff.SelectedItems.Count > 0)
                {
                    selectedStaff.FirstName = tbxFirstName.Text;
                    selectedStaff.LastName = tbxLastname.Text;
                    selectedStaff.Email = tbxEmail.Text;
                    selectedStaff.BirthDate = dtpBirthdate.Value;
                    selectedStaff.Role = rbtnManager.Checked ? Roles.Manager : rbtnBartender.Checked ? Roles.Bartender : rbtnWaiter.Checked ? Roles.Waiter : Roles.Chef;
                    selectedStaff.Employed = cbxEmployed.Checked;
                    staffController.UpdateStaff(selectedStaff);
                    Reload();
                    MessageBox.Show("Werknemer succesvol aangepast");
                }
                else
                {
                    staffController.AddStaff(new Staff(tbxFirstName.Text, tbxLastname.Text, dtpBirthdate.Value, rbtnManager.Checked ? Roles.Manager : rbtnBartender.Checked ? Roles.Bartender : rbtnWaiter.Checked ? Roles.Waiter : rbtnChef.Checked ? Roles.Chef : Roles.None, tbxEmail.Text, cbxEmployed.Checked));
                    Reload();
                    MessageBox.Show("Werknemer succesvol toegevoegd");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void rbtnChef_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnWaiter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnBartender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pnlInputs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtnManager_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ltvStaff.SelectedItems.Clear();
            selectedStaff = null;
            tbxFirstName.Text = null;
            tbxLastname.Text = null;
            tbxEmail.Text = null;
        }
    }
}