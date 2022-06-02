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
                listViewItem.Tag = menuItem;
                ltvMenuItems.Items.Add(listViewItem);
            });
        }
        private void LoadSubCategories(Category category)
        {
            cbxSubcategory.Items.Clear();
            switch (category)
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
                default:
                    foreach (SubCategory i in Enum.GetValues(typeof(SubCategory)))
                    {
                        cbxSubcategory.Items.Add(i);
                    }
                    break;
            }
        }
        private void TranslateSubCatIndex(Category category)
        {
            switch (category)
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
                if (i != Category.None) cbxCategory.Items.Add(i);
            }

            LoadSubCategories(Category.None);

            rbtnInMenuTrue.Checked = true;
        }
        private void ltvMenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltvMenuItems.SelectedItems.Count > 0)
            {
                selectedMenuItem = (Model.MenuItem)ltvMenuItems.SelectedItems[0].Tag;
                tbxShortName.Text = selectedMenuItem.ShortName;
                tbxFullName.Text = selectedMenuItem.FullName;
                cbxCategory.SelectedIndex = (int)selectedMenuItem.Category - 1;

                TranslateSubCatIndex(selectedMenuItem.Category);

                numPriceEx.Value = (decimal)selectedMenuItem.PriceEx;
                if (selectedMenuItem.InMenu) rbtnInMenuTrue.Checked = true;
                else rbtnInMenuFalse.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ltvMenuItems.SelectedItems.Count > 0)
                {
                    selectedMenuItem.ShortName = tbxShortName.Text;
                    selectedMenuItem.FullName = tbxFullName.Text;
                    selectedMenuItem.Category = (Category)(cbxCategory.SelectedIndex + 1);
                    selectedMenuItem.SubCategory = (SubCategory)(cbxSubcategory.SelectedIndex + 1);
                    selectedMenuItem.PriceEx = (float)numPriceEx.Value;
                    selectedMenuItem.InMenu = rbtnInMenuTrue.Checked;
                    menuController.UpdateMenuItem(selectedMenuItem);
                    Reload();
                    MessageBox.Show("Menu item succesvol aangepast.");
                }
                else
                {
                    menuController.AddMenuItem(new Model.MenuItem(tbxShortName.Text, tbxFullName.Text, (Category)(cbxCategory.SelectedIndex + 1), (SubCategory)(cbxSubcategory.SelectedIndex + 1), (float)numPriceEx.Value, rbtnInMenuTrue.Checked));
                    Reload();
                    MessageBox.Show("Menu item succesvol toegevoegd.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            LoadSubCategories((Category)(cbxCategory.SelectedIndex + 1));
        }
    }
}