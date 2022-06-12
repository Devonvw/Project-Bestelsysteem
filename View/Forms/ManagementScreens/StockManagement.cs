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
using System.Diagnostics;

namespace View.Forms.ManagementScreens
{
    public partial class StockManagement : Form
    {
        private StockController stockController;
        private List<Model.MenuItem> menuItemList;
        private Model.MenuItem selectedMenuItem;

        //Load the menuItems
        private void Reload()
        {
            menuItemList = stockController.GetAllMenuItems();
            ltvStockItems.Items.Clear();
            menuItemList.ForEach(menuItem =>
            {
                ListViewItem listViewItem = new ListViewItem(menuItem.ShortName);
                listViewItem.SubItems.Add(menuItem.FullName);
                listViewItem.SubItems.Add(menuItem.Stock.ToString());
                listViewItem.Tag = menuItem;
                ltvStockItems.Items.Add(listViewItem);
            });
            numStock.Value = 0;
        }
        public StockManagement()
        {
            stockController = new StockController();
            InitializeComponent();
        }
        private void StockManagement_Load(object sender, EventArgs e)
        {
            Reload();
            numStock.Enabled = false;
        }
        //Load the stock form the selected item
        private void ltvStockItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltvStockItems.SelectedItems.Count > 0)
            {
                selectedMenuItem = (Model.MenuItem)ltvStockItems.SelectedItems[0].Tag;
                numStock.Value = selectedMenuItem.Stock;
                lblMenuItemName.Text = selectedMenuItem.ShortName;
                numStock.Enabled = true;
            }
            else numStock.Enabled = false;
        }
        //Add 6 to the stock
        private void btnAdd6_Click(object sender, EventArgs e)
        {
            if (ltvStockItems.SelectedItems.Count > 0)
            {
                selectedMenuItem.Stock += 6;
                numStock.Value = selectedMenuItem.Stock;
            }
        }
        //Add 12 to the stock
        private void btnAdd12_Click(object sender, EventArgs e)
        {
            if (ltvStockItems.SelectedItems.Count > 0)
            {
                selectedMenuItem.Stock += 12;
                numStock.Value = selectedMenuItem.Stock;
            }
        }
        //Add 24 to the stock
        private void btnAdd24_Click(object sender, EventArgs e)
        {
            if (ltvStockItems.SelectedItems.Count > 0)
            {
                selectedMenuItem.Stock += 24;
                numStock.Value = selectedMenuItem.Stock;
            }
        }
        //Save the stock of selected menuItem
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ltvStockItems.SelectedItems.Count > 0)
                {
                    stockController.AdjustStock(selectedMenuItem);
                    Reload();
                    MessageBox.Show("Voorraad succesvol aangepast.");
                    numStock.Enabled = false;
                    lblMenuItemName.Text = "";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void numStock_ValueChanged_1(object sender, EventArgs e)
        {
            selectedMenuItem.Stock = (int)numStock.Value;
        }
        //Replace the . decimal with the correct , decimal
        private void numStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }
    }
}