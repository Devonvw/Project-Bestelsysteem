﻿using System;
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
using View.Forms.Order_Screens;
using View.Forms.Order_Screens.Observer;

namespace View.Forms.Order_Screens
{
    public partial class AddOrder : Form
    {
        // fields
        private Bill bill;
        private Staff staff;
        private List<OrderItem> oldOrderItems;
        private List<Model.MenuItem> menuItems;
        private MenuController menuController = new MenuController();
        private OrderController orderController = new OrderController();
        private List<OrderItem> newOrderItems = new List<OrderItem>();
        private int amount = 1;
        private Form activeForm;
        private OrderStatus status;
        

        // constructor
        public AddOrder(List<OrderItem> orderItems, Bill bill, Staff staff)
        {
            InitializeComponent();
            this.bill = bill;
            this.staff = staff;
            this.oldOrderItems = orderItems;
            menuItems = menuController.GetMenuItems();
            FillMenuListView(menuItems);
        }

        // listviews
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
            deleteItemOrderButton.Visible = true;
            deleteItemOrderButton.Enabled = true;
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
            deleteItemOrderButton.Visible = false;
            clearOrderButton.Visible = false;
        }

        // methods for adding items
        private void addItemButton_Click(object sender, EventArgs e)
        {
            addItemToOrderList(newOrderItems);
            //RearrangeOrderList(newOrderItems);
            FillNewOrderListView(newOrderItems);
            clearOrderButton.Enabled = true;
            
        }

        private void addItemToOrderList(List<OrderItem> newOrderItems)
        {
            Model.MenuItem menuItem = new Model.MenuItem();
            menuItem.Id = int.Parse(menuItemsListView.SelectedItems[0].SubItems[0].Text);
            menuItem.ShortName = menuItemsListView.SelectedItems[0].SubItems[1].Text;
            OrderItem orderItem = new OrderItem();
            orderItem.MenuItem = menuItem;
            orderItem.Amount = amount;
            orderItem.Comment = addCommentTextBox.Text;
            if (orderItem.Amount != 0)
            {
                newOrderItems.Add(orderItem);
            }
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
        private void deleteItemOrderButton_Click(object sender, EventArgs e)
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
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            GetAmount();
            amount++;
            SetAmount();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            GetAmount();
            amount--;
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
            Order order = new Order(staff.Id, DateTime.Now);
            order.OrderItems = newOrderItems;
            orderController.InsertOrder(bill, order);           
            OpenChildForm(new Forms.Order_Screens.Overview(oldOrderItems, bill, staff));
        }









        // navigation methods
        private List<Model.MenuItem> DistinctMenuByCategory(Category category)
        {
            List<Model.MenuItem> items = new List<Model.MenuItem>();
            foreach (var item in menuItems)
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
            hidePanels();
            lunchSubPanel.Show();
        }

        private void dinerButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuByCategory(Category.Diner);
            FillMenuListView(menuItems);
            hidePanels();
            dinerSubPanel.Show();
        }

        private void drankenButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuByCategory(Category.NonAlcoholDrinks);
            FillMenuListView(menuItems);
            hidePanels();
            drankenSubPanel.Show();
        }

        private void alcoholButton_Click(object sender, EventArgs e)
        {
            List<Model.MenuItem> menuItems = DistinctMenuByCategory(Category.AlcoholDrinks);
            FillMenuListView(menuItems);
            hidePanels();
            alchoholSubPanel.Show();
        }

        private void hidePanels()
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

        // open another form
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.addOrderPanel.Controls.Add(childForm);
            this.addOrderPanel.Tag = childForm;
            childForm.Size = addOrderPanel.Size;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
