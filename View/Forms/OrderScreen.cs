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
using Controller;

namespace View.Forms
{
    public partial class OrderScreen : Form
    {
        private Bill bill;
        private BillController billController = new BillController();
        private OrderController orderController = new OrderController();
        private Table table;

        public OrderScreen(Table table) // table table
        {
            InitializeComponent();
            this.table = table;
            tableNumberLabel.Text = $"Table {table.Id}";
            Bill bill = billController.GetCurrentBillByTable(table);
            List<OrderItem> orderItems = billController.GetOrderItems(bill);
            listBox1.Items.Clear();
            try
            {
                foreach (OrderItem item in orderItems)
                {
                    ListViewItem li = new ListViewItem(item.MenuItem.ShortName);
                    listBox1.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong : {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
