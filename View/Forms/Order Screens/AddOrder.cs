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
                ListViewItem listViewItem = new ListViewItem(item.ShortName.ToString());
                listViewItem.SubItems.Add(item.Category.ToString());
                listViewItem.SubItems.Add(item.SubcategoryId.ToString());
                listView.Items.Add(listViewItem);
            }
        }
    }
}
