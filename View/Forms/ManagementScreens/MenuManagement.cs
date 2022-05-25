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
    public partial class MenuManagement : Form
    {
        private MenuController menuController;
        private List<Model.MenuItem> menuItemList;
        private Model.MenuItem selectedMenuItem;
        private void Reload()
        {
            menuItemList = menuController.GetAllMenuItems();
            ltvMenuItems.Items.Clear();
            menuItemList.ForEach(menuItem =>
            {
                ListViewItem listViewItem = new ListViewItem(menuItem.ShortName);
                listViewItem.SubItems.Add(menuItem.FullName);
                listViewItem.SubItems.Add(menuItem.Category.ToString());
                listViewItem.SubItems.Add(menuItem.SubCategory.ToString());
                listViewItem.SubItems.Add(menuItem.PriceEx.ToString());
                listViewItem.SubItems.Add(menuItem.InMenu ? "Ja" : "Nee");
                listViewItem.Tag = menuItem.Id;
                ltvMenuItems.Items.Add(listViewItem);
            });
        }
        public MenuManagement()
        {
            menuController = new MenuController();
            InitializeComponent();
        }
        private void MenuManagement_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void ltvMenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltvMenuItems.SelectedItems.Count > 0)
            {
                selectedMenuItem = (Model.MenuItem)menuItemList.Where(menuItem => menuItem.Id == int.Parse(ltvMenuItems.SelectedItems[0].Tag.ToString())).ToList()[0].Clone();
            }
        }

        private void pnlInputs_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
