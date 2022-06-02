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
        private int amountTest { get; set; }

        // Lists
        private List<OrderItem> orderItems = new List<OrderItem>();
        private List<Model.MenuItem> menuItems = new List<Model.MenuItem>();
        private List<OrderItem> newOrderItems = new List<OrderItem>();
        private List<OrderItem> orderItemsInPreparation = new List<OrderItem>();
        private List<OrderItem> rearrangedList = new List<OrderItem>();

        // Controllers
        private MenuController menuController = new MenuController();
        private OrderController orderController = new OrderController();
        private BillController billController = new BillController();
        private StockController stockController = new StockController();


        // constructor
        public Overview(List<OrderItem> orderItems, Bill bill, Staff staff)
        {
            InitializeComponent();
            // set fields
            this.orderItems = orderItems;
            this.staff = staff;
            this.bill = bill;
            this.menuItems = menuController.GetAllMenuItems();
            this.rearrangedList = billController.GetOrderItems(bill);

            // Init
            if (orderItems != null)
            {
                FillBillOverView(rearrangedList);
            }
            if (orderItems.Count == 0)
            {
                ChangeOrderButton.Hide();
            }
            FillMenuListView(menuItems);
            SetActivePanel(overViewPanel);
        }

        // method for setting panel
        private void SetActivePanel(Panel panel)
        {
            // hide the open panel
            if (activePanel != null) { activePanel.Hide(); }

            // open the specified panel
            activePanel = panel;
            panel.Show();
        }

        // Panel Overview
        private void FillBillOverView(List<OrderItem> orderItems)
        {
            billOverViewListView.Items.Clear();
            foreach (OrderItem item in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.MenuItem.ShortName.ToString());
                listViewItem.SubItems.Add(item.Amount.ToString());
                if (item.Comment != null)
                {
                    listViewItem.SubItems.Add(item.Comment.ToString());
                }
                billOverViewListView.Items.Add(listViewItem);
            }
        }

        public void UpdateBillOverview()
        {
            FillBillOverView((orderItems = orderController.GetOrderItemsForOverview(bill)));
            FillNewOrderListView(newOrderItems);
        }


        // Panel Overview: Button Clicks
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            SetActivePanel(addOrderPanel);
            FillNewOrderListView(newOrderItems);
        }

        private void deleteOrderInPreperationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet je zeker dat je alles wilt verwijderen?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) { return; }
            else
            {
                foreach (OrderItem orderItem in orderItemsInPreparation)
                {
                    orderController.DeleteOrderItem(orderItem);
                    // update stock
                    orderItem.MenuItem.Stock = (orderItem.MenuItem.Stock + orderItem.Amount);
                    stockController.AdjustStock(orderItem.MenuItem);
                }
                UpdateBillOverview();
                ChangeOrderButton.Hide();
                commentAndAmountPanel.Hide();
                deleteOrderInPreperationButton.Hide();
                updateItemButton.Hide();
            }
        }

        private List<OrderItem> GetOrderItemsInPreparation(List<OrderItem> orderItems)
        {
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

            FillBillOverView((orderItemsInPreparation = GetOrderItemsInPreparation(orderItems)));
        }

        // update orderItem in DB
        private void updateItemButton_Click(object sender, EventArgs e)
        {
            int stock = 0;
            OrderItem orderItem = new OrderItem();
            foreach (OrderItem item in orderItems)
            {
                if (item.Id == int.Parse(billOverViewListView.SelectedItems[0].SubItems[0].Text))
                {
                    orderItem = item;
                    foreach (Model.MenuItem menuItem in menuItems)
                    {
                        if (menuItem == item.MenuItem)
                        {
                            stock = menuItem.Stock;
                        }
                    }
                    if (amount > stock)
                    {
                        MessageBox.Show("Onvoldoende items in voorraad!");
                        return;
                    }
                    orderItem.Amount = amount;
                    orderItem.Comment = addCommentTextBox.Text;
                }
            }
            GetAmount();
            //  update items
            if (orderItem.Amount == 0) { orderController.DeleteOrderItem(orderItem); }
            else 
            { 
                orderController.UpdateOrderItem(orderItem);
                // Update Stock
                orderItem.MenuItem.Stock = (orderItem.MenuItem.Stock - orderItem.Amount);
                stockController.AdjustStock(orderItem.MenuItem);
            }



            // show buttons
            ChangeOrderButton.Show();
            insertOrderButton.Show();
            togglePanel.Show();

            // hide buttons
            updateItemButton.Hide();
            commentAndAmountPanel.Hide();

            // update
            UpdateBillOverview();
        }

        private void backToTablesButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Panel Overview: Toggles
        private void groupItemsToggle_CheckedChanged(object sender, EventArgs e)
        {
            //checken
            rearrangedList.Clear();
            if (groupItemsToggle.Checked == true) { FillBillOverView(rearrangedList = billController.GetOrderItems(bill)); }
            else if (groupItemsToggle.Checked == false) { FillBillOverView(orderItems); }
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
                listViewItem.SubItems.Add(item.Stock.ToString());
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
                newOrderItemsListView.Items.Add(listViewItem);
            }
        }

        private void menuItemsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            hideButtons();

            // Show Buttons
            addItemButton.BackgroundColor = Color.MediumSlateBlue;
            addItemButton.Enabled = true;
            commentAndAmountPanel.Visible = true;
        }
        private void newOrderItemsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            hideButtons();

            // show Buttons
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
            // add item and reset orderlist
            addItemToOrderList(newOrderItems);
            FillNewOrderListView(newOrderItems);

            // show buttons
            clearOrderButton.Enabled = true;
            insertOrderButton.Enabled = true;
        }

        private void addItemToOrderList(List<OrderItem> newOrderItems)
        {
            // get the menuitem
            Model.MenuItem menuItem = new Model.MenuItem();
            try
            {
                menuItem.Id = int.Parse(menuItemsListView.SelectedItems[0].SubItems[0].Text);
                menuItem.ShortName = menuItemsListView.SelectedItems[0].SubItems[1].Text;
                menuItem.Stock = int.Parse(menuItemsListView.SelectedItems[0].SubItems[2].Text);
            }
            catch
            {
                MessageBox.Show("Er is geen item aangeklikt!");
                return;
            }
            GetAmount();
            if (amount > menuItem.Stock)
            {
                MessageBox.Show("Onvoldoende items in voorraad!");
                return;
            }
            foreach (OrderItem newOrderItem in newOrderItems)
            {
                if (newOrderItem.MenuItem.Id == menuItem.Id)
                {
                    int oldAmount = newOrderItem.Amount;
                    int newAmount = oldAmount + amount;
                    newOrderItem.Amount = newAmount;
                    changeStockInList(menuItem, amount);
                    return;
                }
            }
            changeStockInList(menuItem, amount);
            addItem(menuItem);
            FillNewOrderListView(newOrderItems);
        }

        private void changeStockInList(Model.MenuItem item, int amount)
        {
            foreach (Model.MenuItem menuItem in menuItems)
            {
                if (menuItem.Id == item.Id)
                {
                    menuItem.Stock -= amount;
                }
            }
            FillMenuListView(menuItems);
        }

        // add the item to the list and update list
        public void addItem(Model.MenuItem menuItem)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.MenuItem = menuItem;
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
                    if (amount != 0)
                    {
                        Model.MenuItem menuItem = orderItem.MenuItem;
                        int stock = menuItem.Stock;
                        if (amount > stock)
                        {
                            MessageBox.Show("Onvoldoende items in voorraad!");
                            return;
                        }
                        orderItem.MenuItem.ShortName = newOrderItemsListView.SelectedItems[0].SubItems[0].Text;
                        orderItem.Amount = amount;
                        orderItem.Comment = addCommentTextBox.Text;
                        break;
                    }
                    else
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
            if (amount > 1) { amount--; }
            else
            {
                amount = 0;
                minusButton.Visible = false;
            }
            SetAmount();
        }

        private void insertOrderButton_Click(object sender, EventArgs e)
        {
            if (newOrderItems != null)
            {
                Order order = new Order(staff.Id, DateTime.Now);
                order.OrderItems = newOrderItems;
                orderController.InsertOrder(bill, order);
                // update Stock
                foreach (OrderItem orderItem in order.OrderItems)
                {
                    orderItem.MenuItem.Stock = (orderItem.MenuItem.Stock - orderItem.Amount);
                    stockController.AdjustStock(orderItem.MenuItem);
                }
                SetActivePanel(overViewPanel);
                UpdateBillOverview();
                newOrderItems.Clear();
                groupItemsToggle.Checked = false;
                ChangeOrderButton.Show();
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

        private void LoadMenuByCategory(List<Model.MenuItem> menuItems, Panel panel)
        {
            FillMenuListView(menuItems);
            hideSubNavPanels();
            panel.Show();
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
            LoadMenuByCategory(menuItems, lunchSubPanel);          
        }

        private void dinerButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuByCategory(Category.Diner);
            LoadMenuByCategory(menuItems, dinerSubPanel);
        }

        private void drankenButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuByCategory(Category.NonAlcoholDrinks);
            LoadMenuByCategory(menuItems, drankenSubPanel);
        }

        private void alcoholButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuByCategory(Category.AlcoholDrinks);
            LoadMenuByCategory(menuItems, alchoholSubPanel);
        }

        private void hideSubNavPanels()
        {
            alchoholSubPanel.Hide();
            drankenSubPanel.Hide();
            lunchSubPanel.Hide();
            dinerSubPanel.Hide();
        }

        // nav buttons subcategories

        private void LoadSubcategories(SubCategory subcategory)
        {
            List<Model.MenuItem> menuItems = DistinctMenuBySubCategory(subcategory);
            FillMenuListView(menuItems);
        }
        private void bierButton_Click(object sender, EventArgs e)
        {
            LoadSubcategories(SubCategory.Bier);
        }

        private void wijnButton_Click(object sender, EventArgs e)
        {
            LoadSubcategories(SubCategory.Wijn);
        }

        private void gedestilleerdButton_Click(object sender, EventArgs e)
        {
            LoadSubcategories(SubCategory.GedistilleerdeDranken);
        }

        private void warmeDrankenButton_Click(object sender, EventArgs e)
        {
            LoadSubcategories(SubCategory.WarmeDranken);
        }

        private void frisdrankButton_Click(object sender, EventArgs e)
        {
            LoadSubcategories(SubCategory.Frisdrank);
        }

        private void lunchStarterButton_Click(object sender, EventArgs e)
        {
            LoadSubcategories(SubCategory.LunchStarter);
        }

        private void lunchMainButton_Click(object sender, EventArgs e)
        {
            LoadSubcategories(SubCategory.LunchMain);
        }

        private void lunchDesertButton_Click(object sender, EventArgs e)
        {
            LoadSubcategories(SubCategory.LunchDesert);
        }

        private void dinerStarterButton_Click(object sender, EventArgs e)
        {
            LoadSubcategories(SubCategory.Starter);
        }

        private void dinerSideButton_Click(object sender, EventArgs e)
        {
            LoadSubcategories(SubCategory.Side);
        }

        private void dinerMainButton_Click(object sender, EventArgs e)
        {
            LoadSubcategories(SubCategory.Main);
        }

        private void dinerDesertButton_Click(object sender, EventArgs e)
        {
            LoadSubcategories(SubCategory.Desert);
        }





        private void backToOverviewButton_Click(object sender, EventArgs e)
        {
            if (newOrderItems.Count == 0)
                SetActivePanel(overViewPanel);
            else
            {
                DialogResult result = MessageBox.Show("Er zijn nog ongeplaatste bestellingen in de lijst. Wilt u deze annuleren?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    newOrderItems.Clear();
                    SetActivePanel(overViewPanel);

                    FillMenuListView((menuItems = menuController.GetAllMenuItems()));
                }
            }
        }

    }
}
