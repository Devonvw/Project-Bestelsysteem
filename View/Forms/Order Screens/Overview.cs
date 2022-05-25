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
    public partial class Overview : Form
    {
        // fields     
        private Staff staff;
        private Bill bill;
        private int amount;
        private Panel activePanel;
        // Lists
        private List<OrderItem> orderItems;
        private List<Model.MenuItem> menuItems;
        private List<OrderItem> newOrderItems = new List<OrderItem>();
        private List<OrderItem> orderItemsInPreparation = new List<OrderItem>();
        private List<OrderItem> rearrangedList = new List<OrderItem>();
        private List<Order> orders = new List<Order>();

        // Controllers
        private MenuController menuController = new MenuController();
        private OrderController orderController = new OrderController();
        private BillController billController = new BillController();


        // constructor
        public Overview(List<OrderItem> orderItems, Bill bill, Staff staff)
        {
            InitializeComponent();
            // set fields
            this.orderItems = orderItems;
            this.staff = staff;
            this.bill = bill;
            this.menuItems = menuController.GetMenuItems();
            // Init
            SetActivePanel(overViewPanel);
            if (orderItems != null)
            {
                FillBillOverView(orderItems);
            }
            FillMenuListView(menuItems);
        }


        // method for setting panel
        private void SetActivePanel(Panel panel)
        {
            if (activePanel != null)
            {
                activePanel.Hide();
            }
            activePanel = panel;
            panel.Show();
        }

        // Panel Overview
        private void FillBillOverView(List<OrderItem> orderItems)
        {
            billOverViewListView.Items.Clear();
            foreach (OrderItem item in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.MenuItem.ShortName.ToString());
                listViewItem.SubItems.Add(item.Amount.ToString());
                listViewItem.SubItems.Add(item.Comment.ToString());
                billOverViewListView.Items.Add(listViewItem);
            }
        }

        public void UpdateBillOverview()
        {
            orderItems = billController.GetOrderItems(bill);
            FillBillOverView(orderItems);
        }
        // Panel Overview: Button Clicks
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            SetActivePanel(addOrderPanel);
        }
        private void ChangeOrderButton_Click(object sender, EventArgs e)
        {
            SetActivePanel(changeOrderPanel);
            this.changeOrderPanel.Controls.Add(commentAndAmountPanel);
            commentAndAmountPanel.BringToFront();
            commentAndAmountPanel.Show();
            commentAndAmountPanel.Location = new Point(10, 446);
        }
        private void backToTablesButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Panel Overview: Toggles
        private void orderInPreparationToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!orderInPreparationToggle.Checked)
            {
                foreach (OrderItem item in orderItems)
                {
                    if (item.Ready == false)
                    {
                        orderItemsInPreparation.Add(item);
                        FillBillOverView(orderItemsInPreparation);
                    }
                }
            }
            else
            {
                orderItemsInPreparation.Clear();
                FillBillOverView(orderItems);
            }
        }
        private void groupItemsToggle_CheckedChanged(object sender, EventArgs e)
        {
            rearrangedList.Clear();
            if (groupItemsToggle.Checked)
            {
                foreach(OrderItem item in orderItems)
                {
                    if (true)
                    {
                        rearrangedList.Add(item);
                    }
                }
            }
        }






        // Panel Add Order
        // Panel Add Order: Listviews
        private void FillMenuListView(List<Model.MenuItem> menuItems)
        {
            menuItemsListView.Items.Clear();
            foreach (Model.MenuItem item in menuItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.ShortName.ToString());
                menuItemsListView.Items.Add(listViewItem);
            }
        }

        public void FillNewOrderListView(List<OrderItem> orderItems)
        {
            newOrderItemsListView.Items.Clear();
            foreach (OrderItem item in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.MenuItem.ShortName.ToString());
                listViewItem.SubItems.Add(item.Amount.ToString());
                listViewItem.SubItems.Add(item.Comment.ToString());
                newOrderItemsListView.Items.Add(listViewItem);
            }
        }

        private void RearrangeOrderList(List<OrderItem> newOrderItems)
        {
            // create a new order lists where same items get added 
            throw new NotImplementedException();
        }

        private void menuItemsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            hideButtons();
            addItemButton.BackgroundColor = Color.MediumSlateBlue;
            addItemButton.Enabled = true;
            commentAndAmountPanel.Visible = true;
        }
        private void newOrderItemsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            hideButtons();
            deleteItemFromOrderButton.Visible = true;
            deleteItemFromOrderButton.Enabled = true;
            commentAndAmountPanel.Visible = true;
            clearOrderButton.Visible = true;
            changeItemButton.Visible = true;
            changeItemButton.Enabled = true;
            changeItemButton.BackColor = Color.MediumSlateBlue;
        }

        private void hideButtons()
        {
            addItemButton.BackgroundColor = Color.LightSlateGray;
            addItemButton.Enabled = false;
            changeItemButton.BackgroundColor = Color.LightSlateGray;
            changeItemButton.Enabled = false;
            deleteItemFromOrderButton.Visible = false;
            clearOrderButton.Visible = false;
        }

        // methods for adding items
        private void addItemButton_Click(object sender, EventArgs e)
        {
            addItemToOrderList(newOrderItems);
            //RearrangeOrderList(newOrderItems); // not yet implemented
            FillNewOrderListView(newOrderItems);
            clearOrderButton.Enabled = true;
            insertOrderButton.Enabled = true;
        }

        private void addItemToOrderList(List<OrderItem> newOrderItems)
        {
            Model.MenuItem menuItem = new Model.MenuItem();
            menuItem.Id = int.Parse(menuItemsListView.SelectedItems[0].SubItems[0].Text);
            menuItem.ShortName = menuItemsListView.SelectedItems[0].SubItems[1].Text;
            OrderItem orderItem = new OrderItem();
            orderItem.MenuItem = menuItem;
            GetAmount();
            orderItem.Amount = amount;
            orderItem.Comment = addCommentTextBox.Text;
            if (orderItem.Amount != 0)
            {
                newOrderItems.Add(orderItem);
            }
            clearOrderButton.Visible = true;
            amount = 1;
            SetAmount();
            addCommentTextBox.Clear();
        }

        private void SetAmount()
        {
            amountLabel.Text = amount.ToString();
        }
        private void GetAmount()
        {
            amount = int.Parse(amountLabel.Text);
        }



        // methods for deleting/change/clearing new order

        private void deleteOrderItemFromList()
        {
            foreach (OrderItem orderItem in newOrderItems)
            {
                if (orderItem.MenuItem.ShortName == newOrderItemsListView.SelectedItems[0].SubItems[0].Text)
                {
                    newOrderItems.Remove(orderItem);
                    if (newOrderItems.Count == 0)
                    {
                        insertOrderButton.Enabled = false;
                        clearOrderButton.Enabled = false;
                    }
                    break;
                }
            }
            FillNewOrderListView(newOrderItems);
        }

        private void changeOrderItem()
        {
            foreach (OrderItem orderItem in newOrderItems)
            {
                if (orderItem.MenuItem.ShortName == newOrderItemsListView.SelectedItems[0].SubItems[0].Text && (orderItem.Amount).ToString() == newOrderItemsListView.SelectedItems[0].SubItems[1].Text && orderItem.Comment == newOrderItemsListView.SelectedItems[0].SubItems[2].Text)
                {
                    GetAmount();
                    orderItem.MenuItem.ShortName = newOrderItemsListView.SelectedItems[0].SubItems[0].Text;
                    orderItem.Amount = amount;
                    orderItem.Comment = addCommentTextBox.Text;
                    break;
                }
            }
            FillNewOrderListView(newOrderItems);
            amount = 1;
            SetAmount();
            addCommentTextBox.Clear();
            hideButtons();
        }


        // button clicks deleting/change/clearing new order
        private void deleteItemFromOrderButton_Click(object sender, EventArgs e)
        {
            deleteOrderItemFromList();
        }


        private void changeButton_Click(object sender, EventArgs e)
        {
            changeOrderItem();
        }

        private void clearOrderButton_Click(object sender, EventArgs e)
        {
            newOrderItems.Clear();
            FillNewOrderListView(newOrderItems);
            insertOrderButton.Enabled = false;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            GetAmount();
            amount++;
            if (amount > 0)
            {
                minusButton.Visible = true;
            }
            SetAmount();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            GetAmount();
            if (amount > 1)
            {
                amount--;
            }
            else
            {
                amount = 0;
                minusButton.Visible = false;
            }
            SetAmount();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //if (newOrderItems != null)
            //{

            //}
            this.Close();
        }

        private void insertOrderButton_Click(object sender, EventArgs e)
        {
            if (newOrderItems != null)
            {
                Order order = new Order(staff.Id, DateTime.Now);
                order.OrderItems = newOrderItems;
                orderController.InsertOrder(bill, order);
                SetActivePanel(overViewPanel);
                UpdateBillOverview();
            }
        }

        // navigation methods
        private List<Model.MenuItem> DistinctMenuByCategory(Category category)
        {
            List<Model.MenuItem> items = new List<Model.MenuItem>();
            foreach (Model.MenuItem item in menuItems)
            {
                if (item.Category == category)
                {
                    items.Add(item);
                }
            }
            return items;
        }

        private List<Model.MenuItem> DistinctMenuBySubCategory(SubCategory subCategory)
        {
            List<Model.MenuItem> items = new List<Model.MenuItem>();
            foreach (var item in menuItems)
            {
                if (item.SubCategory == subCategory)
                {
                    items.Add(item);
                }
            }
            return items;
        }

        private void lunchButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuByCategory(Category.Lunch);
            FillMenuListView(menuItems);
            hideSubNavPanels();
            lunchSubPanel.Show();
        }

        private void dinerButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuByCategory(Category.Diner);
            FillMenuListView(menuItems);
            hideSubNavPanels();
            dinerSubPanel.Show();
        }

        private void drankenButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuByCategory(Category.NonAlcoholDrinks);
            FillMenuListView(menuItems);
            hideSubNavPanels();
            drankenSubPanel.Show();
        }

        private void alcoholButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuByCategory(Category.AlcoholDrinks);
            FillMenuListView(menuItems);
            hideSubNavPanels();
            alchoholSubPanel.Show();
        }

        private void hideSubNavPanels()
        {
            alchoholSubPanel.Hide();
            drankenSubPanel.Hide();
            lunchSubPanel.Hide();
            dinerSubPanel.Hide();
        }

        // nav buttons subcategories
        private void bierButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(SubCategory.Bier);
            FillMenuListView(menuItems);
        }

        private void wijnButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(SubCategory.Wijn);
            FillMenuListView(menuItems);
        }

        private void gedestilleerdButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(SubCategory.GedistilleerdeDranken);
            FillMenuListView(menuItems);
        }

        private void warmeDrankenButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(SubCategory.WarmeDranken);
            FillMenuListView(menuItems);
        }

        private void frisdrankButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(SubCategory.Frisdrank);
            FillMenuListView(menuItems);
        }

        private void lunchStarterButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(SubCategory.LunchStarter);
            FillMenuListView(menuItems);
        }

        private void lunchMainButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(SubCategory.LunchMain);
            FillMenuListView(menuItems);
        }

        private void lunchDesertButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(SubCategory.LunchDesert);
            FillMenuListView(menuItems);
        }

        private void dinerStarterButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(SubCategory.Starter);
            FillMenuListView(menuItems);
        }

        private void dinerSideButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(SubCategory.Side);
            FillMenuListView(menuItems);
        }

        private void dinerMainButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(SubCategory.Main);
            FillMenuListView(menuItems);
        }

        private void dinerDesertButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(SubCategory.Desert);
            FillMenuListView(menuItems);
        }

        private void backToOverviewButton_Click(object sender, EventArgs e)
        {
            SetActivePanel(overViewPanel);
        }

        // Panel Change Order

        private void FillOrderItemsInPreparationListView()
        {
            // check orderItems where ready = false
        }

        private DateTime GetDateTime(Order order)
        {
            DateTime dateTime = order.DateTime;
            // get the time of placed order
            return dateTime;
        }

        private bool changeOrderAllowed(DateTime dateTime)
        {
            return true;
        }

        private void changeOrderButton2_Click(object sender, EventArgs e)
        {
            
            //GetDateTime(order);
            
            // change the orderItem
        }
    }
}
