using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using Model;
using System.Diagnostics;

namespace Model.DAL
{
    public class MenuDao : BaseDao
    {
        public void AddMenuItem(MenuItem menuItem)
        {
            
        }

        }
        public void UpdateMenuItem(MenuItem menuItem)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    Id = (int)dr["id"],
                    ShortName = (string)dr["shortName"],
                    FullName = (string)dr["fullName"],
                    Category = (Category)(int)dr["categoryId"],
                    SubcategoryId = (int)dr["subcategoryId"],
                    PriceEx = float.Parse(dr["priceEx"].ToString())
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }

        //public int Id { get; }
        //public string ShortName { get; }
        //public string FullName { get; }
        //public Category Category { get; }
        //public int SubcategoryId { get; }
        //public float PriceEx { get; }
    }
}
