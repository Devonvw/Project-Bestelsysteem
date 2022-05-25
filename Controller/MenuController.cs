using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Controller
{
    public class MenuController
    {
        MenuDao menuDb;

        public MenuController()
        {
            menuDb = new MenuDao();
        }
        public List<MenuItem> GetAllMenuItems()
        {
            return menuDb.GetAllMenuItems();
        }
        public List<MenuItem> GetMenu()
        {
            return menuDb.GetMenu();
        }
        public void AddMenuItem(MenuItem menuItem)
        {
            menuDb.AddMenuItem(menuItem);
        }
        public void ChangeMenu(bool addOrRemove, MenuItem menuItem)
        {
            if (addOrRemove) menuDb.AddToMenu(menuItem);
            else menuDb.RemoveFromMenu(menuItem);
        }
        public void UpdateMenuItem(MenuItem menuItem)
        {
            menuDb.UpdateMenuItem(menuItem);
        }
    }
}
