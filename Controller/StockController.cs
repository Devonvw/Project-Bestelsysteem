using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class StockController
    {
        StockDao stockDB;

        public StockController()
        {
            stockDB = new StockDao();
        }
        public void AdjustStock(bool addOrRemove, int amount)
        {
            if (addOrRemove) stockDB.AddStock(amount);
            else stockDB.RemoveStock(amount);
        }
    }
}
