using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using Model;
using System.Diagnostics;

namespace Model
{
    public class MenuDao : BaseDao
    {
        public List<MenuItem> GetAllMenuItems()
        {
            string query = "SELECT * FROM MenuItems";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetMenu()
        {
            string query = "SELECT * FROM MenuItems WHERE inMenu = 'true'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddMenuItem(MenuItem menuItem)
        {
            string query = "INSERT INTO MenuItems (shortName, fullName, categoryId, subcategoryId, priceEx, stock, inMenu) VALUES(@shortName, @fullName, @categoryId, @subcategoryId, @priceEx, @stock, @inMenu)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@shortName", SqlDbType.VarChar) { Value = menuItem.ShortName },
                new SqlParameter("@fullName", SqlDbType.VarChar) { Value = menuItem.FullName },
                new SqlParameter("@categoryId", SqlDbType.Int) { Value = menuItem.Category },
                new SqlParameter("@subcategoryId", SqlDbType.Int) { Value = menuItem.SubCategory },
                new SqlParameter("@priceEx", SqlDbType.Float) { Value = menuItem.PriceEx },
                new SqlParameter("@stock", SqlDbType.Int) { Value = menuItem.Stock },
                new SqlParameter("@inMenu", SqlDbType.Bit) { Value = menuItem.InMenu }
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddToMenu(MenuItem menuItem)
        {
            string query = "UPDATE MenuItems SET inMenu = 'true' WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = menuItem.Id }
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void RemoveFromMenu(MenuItem menuItem)
        {
            string query = "UPDATE MenuItems SET inMenu = 'false' WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = menuItem.Id }
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateMenuItem(MenuItem menuItem)
        {
            Debug.WriteLine("update");
            string query = "UPDATE MenuItems SET shortName = @shortName, fullName = @fullName, categoryId = @categoryId, subcategoryId = @subcategoryId, priceEx = @priceEx, inMenu = @inMenu WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = menuItem.Id },
                new SqlParameter("@shortName", SqlDbType.VarChar) { Value = menuItem.ShortName },
                new SqlParameter("@fullName", SqlDbType.VarChar) { Value = menuItem.FullName },
                new SqlParameter("@categoryId", SqlDbType.Int) { Value = menuItem.Category },
                new SqlParameter("@subcategoryId", SqlDbType.Int) { Value = menuItem.SubCategory },
                new SqlParameter("@priceEx", SqlDbType.Float) { Value = menuItem.PriceEx },
                new SqlParameter("@inMenu", SqlDbType.Bit) { Value = menuItem.InMenu },
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<MenuItem> ReadTables(DataTable dataTable) {
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

        public void UpdateStock(MenuItem menuItem)
        {
            string query = "UPDATE MenuItems SET stock =@stock WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@stock", SqlDbType.Int) { Value = menuItem.Stock },
                new SqlParameter("@id", SqlDbType.Int) { Value = menuItem.Id },               
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
