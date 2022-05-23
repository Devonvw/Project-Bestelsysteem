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

namespace View.Forms.Order_Screens
{
    public partial class AddOrder : Form
    {
        private Bill bill;
        private Staff staff;
        private List<OrderItem> orderItems;
        private List<Model.MenuItem> menuItems;
        private MenuController menuController = new MenuController();
        private OrderController orderController = new OrderController();
        private List<OrderItem> newOrderItems = new List<OrderItem>();
        private int amount = 1;

        public AddOrder(Bill bill, Staff staff)
        {
            InitializeComponent();
            this.bill = bill;
            this.staff = staff;
            menuItems = menuController.GetMenuItems();
            FillMenuListView(menuItemsListView, menuItems);
        }

        private void FillMenuListView(ListView listView, List<Model.MenuItem> menuItems)
        {
            listView.Items.Clear();
            foreach (Model.MenuItem item in menuItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.ShortName.ToString());
                listViewItem.SubItems.Add(item.Category.ToString());
                listViewItem.SubItems.Add(item.SubCategory.ToString());
                listView.Items.Add(listViewItem);
            }
        }
        public void FillNewOrderListView(ListView listView, List<OrderItem> orderItems)
        {
            listView.Items.Clear();
            foreach (OrderItem item in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.MenuItem.ShortName.ToString());
                listViewItem.SubItems.Add(item.Amount.ToString());
                listView.Items.Add(listViewItem);
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            addItemToOrderList(newOrderItems);
            //RearrangeOrderList(newOrderItems);
            FillNewOrderListView(newOrderItemsListView, newOrderItems);
        }

        private void RearrangeOrderList(List<OrderItem> newOrderItems)
        {
            // create a new order lists where same items get added 
            throw new NotImplementedException();
        }

        private void addItemToOrderList(List<OrderItem> newOrderItems)
        {
            Model.MenuItem menuItem = new Model.MenuItem();
            menuItem.Id = int.Parse(menuItemsListView.SelectedItems[0].SubItems[0].Text);
            menuItem.ShortName = menuItemsListView.SelectedItems[0].SubItems[1].Text;
            OrderItem orderItem = new OrderItem();
            orderItem.MenuItem = menuItem;
            orderItem.Amount = amount;
            if (orderItem.Amount != 0)
            {
                newOrderItems.Add(orderItem);
            }
            amount = 1;
            setAmount();
        }


        private void setAmount()
        {
            amountLabel.Text = amount.ToString();
        }
        private void getAmount()
        {
            amount = int.Parse(amountLabel.Text);
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            getAmount();
            amount++;
            setAmount();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            getAmount();
            amount--;
            setAmount();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void insertOrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order(staff.Id, DateTime.Now);
            order.OrderItems = newOrderItems;
            orderController.InsertOrder(bill, order);
        }
    }
}
