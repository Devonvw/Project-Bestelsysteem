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
using View.Forms.Order_Screens.Observer;

namespace View.Forms.Order_Screens
{
    public partial class Overview : Form/*, IObserver*/
    {
        private Form activeForm;
        private List<OrderItem> orderItems;       
        private Staff staff;
        private Bill bill;
        private OrderController orderController;
        private BillController billController;

        public Overview(List<OrderItem> orderItems, Bill bill, Staff staff)
        {
            InitializeComponent();
            this.orderItems = orderItems;
            this.staff = staff;
            this.bill = bill;
            if (orderItems != null)
            {
                FillListView(bonOverzichtListView, orderItems);
            }
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

        private void newOrderButton_Click(object sender, EventArgs e)
        {           
            OpenChildForm(new Forms.Order_Screens.AddOrder(orderItems, bill, staff));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.overViewPanel.Controls.Add(childForm);
            this.overViewPanel.Tag = childForm;
            childForm.Size = overViewPanel.Size;
            childForm.BringToFront();
            childForm.Show();
        }

        private void toggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!orderInPreparationToggle.Checked)
            {
                // show orderitems where isReady = false
            }
        }

        private void changeOrderButton_Click(object sender, EventArgs e)
        {
            // get orderitems where isReady = false
            // change values/amount of items
        }

        private void groupItemsToggle_CheckedChanged(object sender, EventArgs e)
        {
            // search for similar items and group them ignoring ready/not ready and comments
        }

        // Update

        //public void Update(OrderStatus orderStatus)
        //{
        //    OrderStatus.Bill = orderStatus.Bill;
        //    OrderStatus.Timer = orderStatus.Timer;            
        //}

        //public void UpdateOrderItems()
        //{
        //    this.orderItems = billController.GetOrderItems(bill);
        //    FillListView(bonOverzichtListView, orderItems);
        //}
    }
}
