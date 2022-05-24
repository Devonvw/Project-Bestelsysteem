using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuDao : BaseDao
    {
        public void AddMenuItem(MenuItem menuItem)
        {
            string query = "INSERT INTO MenuItems (shortName, fullName, categoryId, subcategoryId, priceEx, stock, inMenu) VALUES(@shortName, @fullName, @categoryId, @subcategoryId, @priceEx, @stock, @inMenu)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@shortName", SqlDbType.VarChar) { Value = menuItem.ShortName },
                new SqlParameter("@fullName", SqlDbType.VarChar) { Value = menuItem.FullName },
                new SqlParameter("@categoryId", SqlDbType.Int) { Value = menuItem.Category },
                new SqlParameter("@subcategoryId", SqlDbType.Int) { Value = menuItem.SubcategoryId },
                new SqlParameter("@priceEx", SqlDbType.Float) { Value = menuItem.PriceEx },
                new SqlParameter("@stock", SqlDbType.Int) { Value = menuItem.Stock },
                new SqlParameter("@inMenu", SqlDbType.Bit) { Value = menuItem.InMenu }
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void RemoveMenuItem(MenuItem menuItem)
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
            string query = "INSERT INTO MenuItems (shortName, fullName, categoryId, subcategoryId, priceEx, stock, inMenu) VALUES(@shortName, @fullName, @categoryId, @subcategoryId, @priceEx, @stock, @inMenu)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@shortName", SqlDbType.VarChar) { Value = menuItem.ShortName },
                new SqlParameter("@fullName", SqlDbType.VarChar) { Value = menuItem.FullName },
                new SqlParameter("@categoryId", SqlDbType.Int) { Value = menuItem.Category },
                new SqlParameter("@subcategoryId", SqlDbType.Int) { Value = menuItem.SubcategoryId },
                new SqlParameter("@priceEx", SqlDbType.Float) { Value = menuItem.PriceEx },
                new SqlParameter("@stock", SqlDbType.Int) { Value = menuItem.Stock },
                new SqlParameter("@inMenu", SqlDbType.Bit) { Value = menuItem.InMenu }
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
