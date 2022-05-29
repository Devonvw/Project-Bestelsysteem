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

namespace View.Forms.ManagementScreens
{
    public partial class StockManagement : Form
    {
        private StockController stockController;
        private List<Model.MenuItem> menuItemList;
        private Model.MenuItem selectedMenuItem;

        private void Reload()
        {
            menuItemList = stockController.GetAllMenuItems();
            ltvStockItems.Items.Clear();
            menuItemList.ForEach(menuItem =>
            {
                ListViewItem listViewItem = new ListViewItem(menuItem.ShortName);
                listViewItem.SubItems.Add(menuItem.FullName);
                listViewItem.SubItems.Add(menuItem.Stock.ToString());
                listViewItem.Tag = menuItem.Id;
                ltvStockItems.Items.Add(listViewItem);
            });
        }
        public StockManagement()
        {
            stockController = new StockController();
            InitializeComponent();
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void pnlInputs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ltvStockItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltvStockItems.SelectedItems.Count > 0)
            {
                selectedMenuItem = (Model.MenuItem)menuItemList.Where(menuItem => menuItem.Id == int.Parse(ltvStockItems.SelectedItems[0].Tag.ToString())).ToList()[0].Clone();
                numStock.Value = selectedMenuItem.Stock;
            }
            else
            {

            }
        }

        private void btnAdd6_Click(object sender, EventArgs e)
        {
            if (ltvStockItems.SelectedItems.Count > 0)
            {
                selectedMenuItem.Stock += 6;
                numStock.Value = selectedMenuItem.Stock;
            }
        }

        private void btnAdd12_Click(object sender, EventArgs e)
        {
            if (ltvStockItems.SelectedItems.Count > 0)
            {
                selectedMenuItem.Stock += 12;
                numStock.Value = selectedMenuItem.Stock;
            }
        }

        private void btnAdd24_Click(object sender, EventArgs e)
        {
            if (ltvStockItems.SelectedItems.Count > 0)
            {
                selectedMenuItem.Stock += 24;
                numStock.Value = selectedMenuItem.Stock;
            }
        }

        private void numStock_ValueChanged(object sender, EventArgs e)
        {
            if (ltvStockItems.SelectedItems.Count > 0)
            {
                if ((numStock.Value % 1) == 0)
                {
                    selectedMenuItem.Stock = (int)numStock.Value;
                }
            }
            else
            {
                numStock.Value = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ltvStockItems.SelectedItems.Count > 0)
                {
                    stockController.AdjustStock(selectedMenuItem);
                    Reload();
                    MessageBox.Show("Voorraad succesvol aangepast.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
