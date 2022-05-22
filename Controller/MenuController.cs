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

        public List<MenuItem> GetMenuItems()
        {
            return menuDb.GetAllMenuItems();
        }
    }
}
