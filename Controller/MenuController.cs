using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;


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
        public void AddMenuItem(MenuItem menuItem)
        {
            ValidateMenuItem(menuItem);
            menuDb.AddMenuItem(menuItem);
        }
        public void UpdateMenuItem(MenuItem menuItem)
        {
            ValidateMenuItem(menuItem);
            menuDb.UpdateMenuItem(menuItem);
        }
        private void ValidateMenuItem(MenuItem menuItem)
        {
            if (string.IsNullOrEmpty(menuItem.ShortName)) throw new Exception("De korte naam is nog niet ingevuld");
            if (string.IsNullOrEmpty(menuItem.FullName)) throw new Exception("De volledige naam is nog niet ingevuld");
            if (menuItem.Category == 0) throw new Exception("Kies een categorie");
            if (menuItem.SubCategory == 0) throw new Exception("Kies een subcategorie");
            if (menuItem.PriceEx <= 0) throw new Exception("Klopt de prijs?");
        }
    }
}
