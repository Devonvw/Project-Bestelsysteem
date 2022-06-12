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
    public partial class Overview : Form
    {
        OrderScreenParent orderScreenParent;

        // fields     
        private Staff staff;
        private Bill bill;
        private int amount = 1;
        private int duplicateItemAmount;
        private Panel activePanel;
        private Label title;

        // Lists
        private List<OrderItem> orderItems = new List<OrderItem>();
        private List<Model.MenuItem> menuItems = new List<Model.MenuItem>();
        private List<OrderItem> newOrderItems = new List<OrderItem>();
        private List<OrderItem> orderItemsInPreparation = new List<OrderItem>();
        private List<OrderItem> rearrangedList = new List<OrderItem>();
        private List<Order> orders = new List<Order>();

        // ListViewItems
        private OrderItem selectedOrderItem;
        private Model.MenuItem selectedMenuItem;
        private OrderItem selectedNewOrderItem;

        // Controllers
        private MenuController menuController = new MenuController();
        private OrderController orderController = new OrderController();
        private BillController billController = new BillController();
        private StockController stockController = new StockController();



        // constructor
        public Overview(List<OrderItem> orderItems, Bill bill, Staff staff, Label tableNumberLabel, OrderScreenParent orderScreenParent)
        {
            InitializeComponent();
            // set fields
            this.orderItems = orderItems;
            this.staff = staff;
            this.bill = bill;
            this.orderScreenParent = orderScreenParent;
            this.title = tableNumberLabel;
            // set lists
            this.menuItems = menuController.GetAllMenuItems();
            this.rearrangedList = billController.GetOrderItems(bill);

            // Init
            Init();
        }

        private void Init()
        {
            SetActivePanel(overViewPanel);
            if (orderItems.Count > 0) { FillBillOverView(rearrangedList); }
            else { ChangeOrderButton.Hide(); }

            SetAmount();
            commentAndAmountPanel.Hide();
            deleteOrderInPreperationButton.Hide();
            updateItemButton.Hide();
            togglePanel.Show();
        }


        // method for setting panel
        private void SetActivePanel(Panel panel)
        {
            if (activePanel != null) { activePanel.Hide(); }
            activePanel = panel;
            panel.Show();
        }
        // set amount Label 
        private void SetAmount()
        {
            amountLabel.Text = amount.ToString();
        }

        // Fill Listview methods
        private void FillBillOverView(List<OrderItem> orderItems)
        {
            billOverViewListView.Items.Clear();
            foreach (OrderItem item in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.MenuItem.ShortName.ToString());
                listViewItem.SubItems.Add(item.Amount.ToString());
                if (item.Comment != null) { listViewItem.SubItems.Add(item.Comment.ToString()); }
                listViewItem.Tag = item;
                billOverViewListView.Items.Add(listViewItem);
            }
        }

        private void FillMenuListView(List<Model.MenuItem> menuItems)
        {
            menuItemsListView.Items.Clear();
            foreach (Model.MenuItem item in menuItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.ShortName.ToString());
                listViewItem.SubItems.Add(item.Stock.ToString());
                listViewItem.Tag = item;
                menuItemsListView.Items.Add(listViewItem);
            }
        }

        public void FillNewOrderListView(List<OrderItem> newOrderItems)
        {
            newOrderItemsListView.Items.Clear();
            foreach (OrderItem item in newOrderItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.MenuItem.ShortName.ToString());
                listViewItem.SubItems.Add(item.Amount.ToString());
                listViewItem.SubItems.Add(item.Comment.ToString());
                listViewItem.Tag = item;
                newOrderItemsListView.Items.Add(listViewItem);
            }
        }


        // update the BillListView
        private void UpdateBillOverview()
        {
            FillBillOverView((orderItems = orderController.GetOrderItemsForOverview(bill)));
        }

        private void UpdateMenuItems()
        {
            menuItems = menuController.GetAllMenuItems();
            FillMenuListView(menuItems);
        }


        // set the selected orderItem
        private void billOverViewListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (billOverViewListView.SelectedItems.Count > 0)
            {
                selectedOrderItem = (OrderItem)billOverViewListView.SelectedItems[0].Tag;
            }
            amount = selectedOrderItem.Amount;
            SetAmount();
        }

        // set the selected menuItem
        private void menuItemsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuItemsListView.SelectedItems.Count > 0)
            {
                selectedMenuItem = (Model.MenuItem)menuItemsListView.SelectedItems[0].Tag;
            }
            amount = 1;
            SetAmount();
        }

        // set the selected newOrderItem
        private void newOrderItemsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newOrderItemsListView.SelectedItems.Count > 0)
            {
                selectedNewOrderItem = (OrderItem)newOrderItemsListView.SelectedItems[0].Tag;
            }
            amount = selectedNewOrderItem.Amount;
            SetAmount();
        }





        // Panel Overview: Button Clicks
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            SetActivePanel(addOrderPanel);
            FillMenuListView((menuItems = menuController.GetAllMenuItems()));
        }

        private void deleteOrderInPreperationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet je zeker dat je alles wilt verwijderen?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) { DeleteOrderItemsInPreparation(orderItemsInPreparation); }
        }
        // button click to get options to change orderitems
        private void ChangeOrderButton_Click(object sender, EventArgs e)
        {
            // bring panel to front
            this.overViewPanel.Controls.Add(commentAndAmountPanel);
            commentAndAmountPanel.BringToFront();
            commentAndAmountPanel.Show();
            commentAndAmountPanel.Location = new Point(10, 487);
            // show buttons
            updateItemButton.Show();
            deleteOrderInPreperationButton.Show();
            // hide buttons
            ChangeOrderButton.Hide();
            togglePanel.Hide();
            // get the items that can be changed
            FillBillOverView((orderItemsInPreparation = GetOrderItemsInPreparation(orderItems)));
        }

        // update orderItem in DB
        private void updateItemButton_Click(object sender, EventArgs e)
        {
            updateItem();
            Init();
            UpdateBillOverview();
            UpdateMenuItems();
        }

        private void backToTablesButton_Click(object sender, EventArgs e)
        {
            title.Text = "Tafels";
            Close();
        }

        private void updateItem()
        {
            OrderItem orderItem = selectedOrderItem;
            int oldAmount = orderItem.Amount;
            // get current stock from DB
            foreach (Model.MenuItem menuItem in menuItems)
            {
                if (orderItem.MenuItem.Id == menuItem.Id)
                {
                    orderItem.MenuItem.Stock = menuItem.Stock;
                }
            }
            if (EnoughInStock(orderItem, oldAmount) == true) ;
            {
                orderItem.Amount = int.Parse(amountLabel.Text);
                orderItem.Comment = addCommentTextBox.Text;
                UpdateStock(orderItem, oldAmount);
                if (orderItem.Amount == 0) { orderController.DeleteOrderItem(orderItem); }
                else { orderController.UpdateOrderItem(orderItem); }
            }
        }

        // check for enough stock
        private bool EnoughInStock(OrderItem orderItem, int oldAmount)
        {
            if (amount > (orderItem.MenuItem.Stock + oldAmount))
            {
                MessageBox.Show($"Onvoldoende items in voorraad! voorraad = {orderItem.MenuItem.Stock}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        // update the stock
        private void UpdateStock(OrderItem orderItem, int oldAmount)
        {
            orderItem.MenuItem.Stock = (orderItem.MenuItem.Stock + oldAmount - orderItem.Amount);
            stockController.AdjustStock(orderItem.MenuItem);
            UpdateMenuItems();
        }

        // get the order Items in preperation
        private List<OrderItem> GetOrderItemsInPreparation(List<OrderItem> orderItems)
        {
            // maybe from DB
            orderItemsInPreparation.Clear();
            foreach (OrderItem item in orderItems)
            {
                if (item.Ready == false)
                {
                    orderItemsInPreparation.Add(item);
                }
            }
            return orderItemsInPreparation;
        }

        // Delete complete orders in preparation
        private void DeleteOrderItemsInPreparation(List<OrderItem> orderItems)
        {
            foreach (OrderItem orderItem in orderItemsInPreparation)
            {
                orderController.DeleteOrderItem(orderItem);
                int oldAmount = orderItem.Amount;
                orderItem.Amount = 0;
                UpdateStock(orderItem, oldAmount);
            }
            UpdateBillOverview();
            Init();
        }


        // Panel Overview: Toggles
        private void groupItemsToggle_CheckedChanged(object sender, EventArgs e)
        {
            rearrangedList.Clear();
            if (groupItemsToggle.Checked == true) { FillBillOverView(rearrangedList = billController.GetOrderItems(bill)); }
            else { FillBillOverView(orderItems); }
        }



        // Panel Add Order
        // Panel Add Order: Listviews

        private void menuItemsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            HideButtons();
            // Show Buttons
            addItemButton.BackgroundColor = Color.MediumSlateBlue;
            addItemButton.Enabled = true;
            commentAndAmountPanel.Visible = true;
        }
        private void newOrderItemsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            HideButtons();
            // show Buttons
            deleteItemFromOrderButton.Visible = true;
            deleteItemFromOrderButton.Enabled = true;
            commentAndAmountPanel.Visible = true;
            clearOrderButton.Visible = true;
            changeItemButton.Visible = true;
            changeItemButton.Enabled = true;
            changeItemButton.BackColor = Color.MediumSlateBlue;
        }

        private void HideButtons()
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
            // add item and reset orderlist
            AddItemToOrderList(newOrderItems);
            FillNewOrderListView(newOrderItems);

            // show buttons
            clearOrderButton.Enabled = true;
            insertOrderButton.Enabled = true;
        }

        private void AddItemToOrderList(List<OrderItem> newOrderItems)
        {
            Model.MenuItem menuItem = selectedMenuItem;
            OrderItem orderItem = new OrderItem();
            orderItem.MenuItem = menuItem;
            orderItem.Amount = amount;
            orderItem.Comment = addCommentTextBox.Text;
            if (EnoughInStock(orderItem, 0) == true)
            {
                if (ItemIsDuplicate(orderItem) == true)
                {
                    if (EnoughInStock(orderItem, duplicateItemAmount) == true)
                        SetNewOrderItemAmount(menuItem);
                }
                else if (orderItem.Amount != 0)
                {
                    newOrderItems.Add(orderItem);
                }
                UpdateStock(orderItem, 0);
                FillNewOrderListView(newOrderItems);
            }
        }

        // set the new amount if item was already added
        private void SetNewOrderItemAmount(Model.MenuItem menuItem)
        {
            foreach (OrderItem newOrderItem in newOrderItems)
            {
                if (newOrderItem.MenuItem.Id == menuItem.Id)
                {
                    newOrderItem.Amount = (newOrderItem.Amount + amount);
                }
            }
        }
        private bool ItemIsDuplicate(OrderItem orderItem)
        {
            foreach (OrderItem newOrderItem in newOrderItems)
            {
                if (newOrderItem.MenuItem.Id == orderItem.MenuItem.Id && newOrderItem.Comment == orderItem.Comment)
                {
                    duplicateItemAmount = newOrderItem.Amount;
                    return true;
                }
            }
            return false;
        }


        // methods for deleting/change/clearing new order
        private void deleteOrderItemFromList()
        {
            OrderItem orderItem = selectedNewOrderItem;
            int oldAmount = orderItem.Amount;
            orderItem.Amount = 0;
            newOrderItems.Remove(orderItem);
            UpdateStock(orderItem, oldAmount);
            if (newOrderItems.Count == 0)
            {
                insertOrderButton.Enabled = false;
                clearOrderButton.Enabled = false;
            }
            FillNewOrderListView(newOrderItems);
        }

        private void changeOrderItem()
        {
            OrderItem orderItem = selectedNewOrderItem;
            int oldAmount = orderItem.Amount;
            if (amount != 0)
            {
                orderItem.Amount = amount;
                if (EnoughInStock(orderItem, oldAmount) == true)
                {
                    orderItem.Comment = addCommentTextBox.Text;
                    UpdateStock(orderItem, oldAmount);
                }
            }
            else
            {
                newOrderItems.Remove(orderItem);
                UpdateStock(orderItem, oldAmount);
            }
            if (newOrderItems.Count == 0)
            {
                insertOrderButton.Enabled = false;
                clearOrderButton.Enabled = false;
            }
            FillNewOrderListView(newOrderItems);
            addCommentTextBox.Clear();
            HideButtons();
        }

        private void ClearOrder()
        {
            foreach (OrderItem orderItem in newOrderItems)
            {
                int oldAmount = orderItem.Amount;
                orderItem.Amount = 0;
                UpdateStock(orderItem, oldAmount);
            }
            newOrderItems.Clear();
            FillNewOrderListView(newOrderItems);
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
            ClearOrder();
            UpdateMenuItems();
            insertOrderButton.Enabled = false;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            amount++;
            if (amount > 0)
            {
                minusButton.Visible = true;
            }
            SetAmount();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (amount > 1) { amount--; }
            else
            {
                amount = 0;
                minusButton.Visible = false;
            }
            SetAmount();
        }

        // insert Order
        private void insertOrderButton_Click(object sender, EventArgs e)
        {
            if (newOrderItems != null)
            {
                // insert order into DB
                Order order = new Order(staff.Id, DateTime.Now);
                InsertOrder(order);
                SetActivePanel(overViewPanel);
                UpdateBillOverview();
                newOrderItems.Clear();
                FillNewOrderListView(newOrderItems);
                groupItemsToggle.Checked = false;
                ChangeOrderButton.Show();
            }
        }

        // insert Order into DB
        private void InsertOrder(Order order)
        {
            order.OrderItems = newOrderItems;
            orderController.InsertOrder(bill, order);
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
            foreach (Model.MenuItem item in menuItems)
            {
                if (item.SubCategory == subCategory)
                {
                    items.Add(item);
                }
            }
            return items;
        }

        private void LoadMenuByCategory(Panel panel, Category category)
        {
            menuItems = menuController.GetAllMenuItems();
            FillMenuListView(menuItems = DistinctMenuByCategory(category));
            hideSubNavPanels();
            panel.Show();
        }

        private void LoadMenuBySubcategories(SubCategory subcategory)
        {
            menuItems = menuController.GetAllMenuItems();
            FillMenuListView(menuItems = DistinctMenuBySubCategory(subcategory));
        }

        private void lunchButton_Click(object sender, EventArgs e)
        {
            LoadMenuByCategory(lunchSubPanel, Category.Lunch);
        }

        private void dinerButton_Click(object sender, EventArgs e)
        {
            LoadMenuByCategory(dinerSubPanel, Category.Diner);
        }

        private void drankenButton_Click(object sender, EventArgs e)
        {
            LoadMenuByCategory(drankenSubPanel, Category.NonAlcoholDrinks);
        }

        private void alcoholButton_Click(object sender, EventArgs e)
        {
            LoadMenuByCategory(alchoholSubPanel, Category.AlcoholDrinks);
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
            LoadMenuBySubcategories(SubCategory.Bier);
        }

        private void wijnButton_Click(object sender, EventArgs e)
        {
            LoadMenuBySubcategories(SubCategory.Wijn);
        }

        private void gedestilleerdButton_Click(object sender, EventArgs e)
        {
            LoadMenuBySubcategories(SubCategory.GedistilleerdeDranken);
        }

        private void warmeDrankenButton_Click(object sender, EventArgs e)
        {
            LoadMenuBySubcategories(SubCategory.WarmeDranken);
        }

        private void frisdrankButton_Click(object sender, EventArgs e)
        {
            LoadMenuBySubcategories(SubCategory.Frisdrank);
        }

        private void lunchStarterButton_Click(object sender, EventArgs e)
        {
            LoadMenuBySubcategories(SubCategory.LunchStarter);
        }

        private void lunchMainButton_Click(object sender, EventArgs e)
        {
            LoadMenuBySubcategories(SubCategory.LunchMain);
        }

        private void lunchDesertButton_Click(object sender, EventArgs e)
        {
            LoadMenuBySubcategories(SubCategory.LunchDesert);
        }

        private void dinerStarterButton_Click(object sender, EventArgs e)
        {
            LoadMenuBySubcategories(SubCategory.Starter);
        }

        private void dinerSideButton_Click(object sender, EventArgs e)
        {
            LoadMenuBySubcategories(SubCategory.Side);
        }

        private void dinerMainButton_Click(object sender, EventArgs e)
        {
            LoadMenuBySubcategories(SubCategory.Main);
        }

        private void dinerDesertButton_Click(object sender, EventArgs e)
        {
            LoadMenuBySubcategories(SubCategory.Desert);
        }

        private void backToOverviewButton_Click(object sender, EventArgs e)
        {
            if (newOrderItems.Count == 0)
                SetActivePanel(overViewPanel);
            else
            {
                DialogResult result = MessageBox.Show("Er zijn nog ongeplaatste bestellingen in de lijst. Wilt u deze annuleren?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ClearOrder();
                    SetActivePanel(overViewPanel);
                    UpdateMenuItems();
                }
                else { return; }
            }
        }


    }
}
