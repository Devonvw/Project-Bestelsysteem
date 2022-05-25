using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms.ManagementScreens
{
    public partial class OverviewManagement : Form
    {
        private Management mainForm;
        public OverviewManagement(Management mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void cbtnWerknemers_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new StaffManagement(), sender);
        }

        private void OverviewManagement_Load(object sender, EventArgs e)
        {

        }

        private void cbtnMenu_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new MenuManagement(), sender);
        }
    }
}
