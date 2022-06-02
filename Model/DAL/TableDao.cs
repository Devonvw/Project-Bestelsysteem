using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TableDao : BaseDao
    {
        public List<Table> GetAllTables()
        {
            string query = "SELECT T.*, B.[datetime] FROM Tables as T LEFT JOIN(SELECT b1.* FROM Bills b1 LEFT JOIN Bills b2 ON(b1.[tableId] = b2.[tableId] AND b1.[datetime] < b2.[datetime]) WHERE b2.id IS NULL) AS B ON T.id = B.tableId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void ChangeOccupied(Table table)
        {
            string query = "UPDATE tables SET occupied = @occupied WHERE id = @id;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", table.Id),
                new SqlParameter("@occupied", table.Occupied),
                //new SqlParameter("@timeSeated", table.TimeSeated)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    Id = (int)dr["id"],
                    Occupied = (bool)dr["occupied"],
                };
                if (dr["datetime"].ToString() == "")
                {
                    table.TimeSeated = DateTime.MinValue;
                }
                else if(dr["datetime"].ToString() != "")
                {
                    table.TimeSeated = (DateTime)dr["datetime"];
                }
                tables.Add(table);
            }
            return tables;
        }
    }
}
