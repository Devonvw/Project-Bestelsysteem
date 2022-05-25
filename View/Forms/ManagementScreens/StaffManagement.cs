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
        public StaffManagement()
        {
            staffController = new StaffController();
            InitializeComponent();
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            List<Staff> staffList = staffController.GetAllStaff();
            staffList.ForEach(staff =>
            {
                ListViewItem listViewItem = new ListViewItem(staff.FirstName);
                listViewItem.SubItems.Add(staff.LastName);
                listViewItem.SubItems.Add(staff.BirthDate.ToString("MM-dd-yyyy"));
                listViewItem.SubItems.Add(staff.Role.ToString());
                listViewItem.SubItems.Add(staff.Email);
                listViewItem.Tag = staff.Id;
                ltvStaff.Items.Add(listViewItem);
            });
        }


    }
}
