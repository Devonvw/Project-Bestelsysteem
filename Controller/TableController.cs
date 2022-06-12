using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Controller
{
    public class TableController
    {
        TableDao tabledDb;
        public TableController()
        {
            tabledDb = new TableDao();
        }

        public List<Table> GetAllTables()
        {
            return tabledDb.GetAllTables();
        }

        public void ChangeOccupied(Table table)
        {
            tabledDb.ChangeOccupied(table);
        }
        public Table GetLastOrdered(Table table)
        {
            return tabledDb.GetLastOrdered(table);
        }
        public bool TableHasOrdered(Table table)
        {
            return tabledDb.TableHasOrdered(table);
        }
    }
}
