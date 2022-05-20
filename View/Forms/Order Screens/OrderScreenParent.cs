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
    public partial class OrderScreenParent : Form
    {
        private BillController billController = new BillController();
        private OrderController orderController = new OrderController();
        private Table table;
        private Form activeForm;
        public OrderScreenParent(Table table) // table table
        {
            InitializeComponent();
            this.table = table;
            tableNumberLabel.Text = $"Tafel {table.Id}";
            Bill bill = billController.GetCurrentBillByTable(table);
            List<OrderItem> orderItems = billController.GetOrderItems(bill);
            OpenChildForm(new Order_Screens.Overview(orderItems));
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.childFormPanel.Controls.Add(childForm);
            this.childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // methods listview

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
