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
    public partial class MenuManagement : Form
    {
        public static readonly List<SubCategory> AlcoholSubs = new List<SubCategory>() { SubCategory.Bier, SubCategory.Wijn, SubCategory.GedistilleerdeDranken };
        public static readonly List<SubCategory> NonAlcoholSubs = new List<SubCategory>() { SubCategory.WarmeDranken, SubCategory.Frisdrank };
        public static readonly List<SubCategory> LunchSubs = new List<SubCategory>() { SubCategory.LunchStarter, SubCategory.LunchMain, SubCategory.LunchDesert };
        public static readonly List<SubCategory> DinerSubs = new List<SubCategory>() { SubCategory.Starter, SubCategory.Side, SubCategory.Main, SubCategory.Desert };

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
            foreach (Category i in Enum.GetValues(typeof(Category)))
            {
                cbxCategory.Items.Add(i);
            }
            foreach (SubCategory i in Enum.GetValues(typeof(SubCategory)))
            {
                cbxSubcategory.Items.Add(i);
            }
            rbtnInMenuTrue.Checked = true;
        }

        private void ltvMenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltvMenuItems.SelectedItems.Count > 0)
            {
                selectedMenuItem = (Model.MenuItem)menuItemList.Where(menuItem => menuItem.Id == int.Parse(ltvMenuItems.SelectedItems[0].Tag.ToString())).ToList()[0].Clone();
                tbxShortName.Text = selectedMenuItem.ShortName;
                tbxFullName.Text = selectedMenuItem.FullName;
                cbxCategory.SelectedIndex = (int)selectedMenuItem.Category -1;

                switch (selectedMenuItem.Category)
                {
                    case Category.AlcoholDrinks:
                        cbxSubcategory.SelectedIndex = (int)AlcoholSubs.FindIndex(subcategory => subcategory == selectedMenuItem.SubCategory);
                        break;
                    case Category.NonAlcoholDrinks:
                        cbxSubcategory.SelectedIndex = (int)NonAlcoholSubs.FindIndex(subcategory => subcategory == selectedMenuItem.SubCategory);
                        break;
                    case Category.Lunch:
                        cbxSubcategory.SelectedIndex = (int)LunchSubs.FindIndex(subcategory => subcategory == selectedMenuItem.SubCategory);
                        break;
                    case Category.Diner:
                        cbxSubcategory.SelectedIndex = (int)DinerSubs.FindIndex(subcategory => subcategory == selectedMenuItem.SubCategory);
                        break;
                }

                numPriceEx.Value = (decimal)selectedMenuItem.PriceEx;
                if (selectedMenuItem.InMenu) rbtnInMenuTrue.Checked = true;
                else rbtnInMenuFalse.Checked = true;
            }
            else
            {

            }
        }

        private void pnlInputs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool selectedInMenu = true;
            if (rbtnInMenuTrue.Checked) selectedInMenu = true;
            else selectedInMenu = false;
            try
            {
                if (ltvMenuItems.SelectedItems.Count > 0)
                {
                    selectedMenuItem.ShortName = tbxShortName.Text;
                    selectedMenuItem.FullName = tbxFullName.Text;
                    selectedMenuItem.Category = (Category)(cbxCategory.SelectedIndex + 1);
                    selectedMenuItem.SubCategory = (SubCategory)(cbxSubcategory.SelectedIndex + 1);
                    selectedMenuItem.PriceEx = (float)numPriceEx.Value;
                    selectedMenuItem.InMenu = selectedInMenu;
                    menuController.UpdateMenuItem(selectedMenuItem);
                    Reload();
                    MessageBox.Show("Menu item succesvol aangepast.");
                }
                else
                {
                    menuController.AddMenuItem(new Model.MenuItem(tbxShortName.Text, tbxFullName.Text, (Category)(cbxCategory.SelectedIndex + 1), (SubCategory)(cbxSubcategory.SelectedIndex + 1), (float)numPriceEx.Value, selectedInMenu));
                    Reload();
                    MessageBox.Show("Menu item succesvol toegevoegd.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void lblInMenu_Click(object sender, EventArgs e)
        {

        }

        private void rbtnInMenuFalse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnInMenuTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numPriceEx_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ltvMenuItems.SelectedItems.Clear();
            selectedMenuItem = null;
            tbxShortName.Text = null;
            tbxFullName.Text = null;
            cbxCategory.SelectedIndex = -1;
            cbxSubcategory.SelectedIndex = -1;
            numPriceEx.Value = 0;
            rbtnInMenuTrue.Checked = true;
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSubcategory.Items.Clear();
            switch ((Category)(cbxCategory.SelectedIndex + 1))
            {
                case Category.AlcoholDrinks:
                    AlcoholSubs.ForEach(subcategory => cbxSubcategory.Items.Add(subcategory));
                    break;
                case Category.NonAlcoholDrinks:
                    NonAlcoholSubs.ForEach(subcategory => cbxSubcategory.Items.Add(subcategory));
                    break;
                case Category.Lunch:
                    LunchSubs.ForEach(subcategory => cbxSubcategory.Items.Add(subcategory));
                    break;
                case Category.Diner:
                    DinerSubs.ForEach(subcategory => cbxSubcategory.Items.Add(subcategory));
                    break;
            }
        }
    }
}
