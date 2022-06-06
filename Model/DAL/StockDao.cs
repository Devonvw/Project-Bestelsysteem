using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StockDao : BaseDao
    {
        public List<MenuItem> GetAllMenuItems()
        {
            string query = "SELECT * FROM MenuItems ORDER BY stock";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateStock(MenuItem menuItem)
        {
            string query = "UPDATE MenuItems SET stock = @stock WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = menuItem.Id },
                new SqlParameter("@stock", SqlDbType.VarChar) { Value = menuItem.Stock },
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        private List<MenuItem> ReadTables(DataTable dataTable)
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
                    SubCategory = (SubCategory)(int)dr["subcategoryId"],
                    PriceEx = float.Parse(dr["priceEx"].ToString()),
                    Stock = (int)dr["stock"],
                    InMenu = (bool)dr["inMenu"]
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
    }
}
