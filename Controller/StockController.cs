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
    public class StockController
    {
        StockDao stockDB;

        public StockController()
        {
            stockDB = new StockDao();
        }
        public List<MenuItem> GetAllMenuItems()
        {
            return stockDB.GetAllMenuItems();
        }
        public void AdjustStock(MenuItem menuItem)
        {
            stockDB.UpdateStock(menuItem);
        }
    }
}
