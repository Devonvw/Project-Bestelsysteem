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
        private List<Order> orderItems;
        private List<Model.MenuItem> menuItems;
        private MenuController menuController = new MenuController();
        private OrderController orderController = new OrderController();
        private List<OrderItem> newOrderItems = new List<OrderItem>();

        public AddOrder()
        {
            InitializeComponent();
            menuItems = menuController.GetMenuItems();
            FillListView(menuItemsListView, menuItems);
        }

        private void FillListView(ListView listView, List<Model.MenuItem> menuItems)
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

        public void addItemToOrder()
        {

        }

        private void menuItemsListView_ItemActivate(object sender, EventArgs e)
        {
            int menuItemId = int.Parse(menuItemsListView.SelectedItems[0].SubItems[0].Text);

        }
    }
}
