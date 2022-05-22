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
        private Form activeForm;
        public Overview(List<OrderItem> orderItems)
        {
            InitializeComponent();
            //UpdateListBox(BillOverview, orderItems);
            FillListView(bonOverzichtListView, orderItems);
        }

        public void FillListView(ListView listView, List<OrderItem> orderItems)
        {
            bonOverzichtListView.Items.Clear();
            foreach (OrderItem item in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.MenuItem.ShortName.ToString());
                listViewItem.SubItems.Add(item.Amount.ToString());
                listViewItem.SubItems.Add(item.Comment.ToString());
                listView.Items.Add(listViewItem);
            }
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

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
