using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View.Forms.Order_Screens
{
    public partial class Overview : Form
    {
        public Overview(List<OrderItem> orderItems)
        {
            InitializeComponent();
            UpdateListBox(BillOverview, orderItems);
        }

        public void UpdateListBox(ListBox listBox, List<OrderItem> orderItems)
        {
            listBox.Items.Clear();
            listBox.DataSource = orderItems;
            listBox.DisplayMember = "ShortName";
        }
        private void Overview_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
