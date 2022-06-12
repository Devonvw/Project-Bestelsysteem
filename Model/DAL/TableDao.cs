using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TableDao : BaseDao
    {
        public List<Table> GetAllTables()
        {
            string query = "SELECT T.*, B.[datetime] FROM Tables as T LEFT JOIN(SELECT b1.* FROM Bills b1 LEFT JOIN Bills b2 ON(b1.[tableId] = b2.[tableId] AND b1.[datetime] < b2.[datetime]) WHERE b2.id IS NULL AND b1.payed = 'false') AS B ON T.id = B.tableId";
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
        public Table GetLastOrdered(Table table)
        {
            string query = "SELECT TOP 1 O.[datetime], B.[tableId] FROM orders AS O JOIN BillItems AS BI ON O.[id] = BI.orderId JOIN bills AS B ON B.[id] = BI.billId WHERE b.tableId = @tableId AND b.payed = 'false' ORDER BY O.[datetime] DESC";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tableId", table.Id),
            };
            return ReadTableLastOrder(ExecuteSelectQuery(query, sqlParameters));
        }
        private Table ReadTableLastOrder(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                Table table = new Table()
                {
                    Id = (int)dataTable.Rows[0]["tableId"],
                    LastOrdered = (DateTime)dataTable.Rows[0]["datetime"],
                };
                return table;
            }
            return null;
        }
        public bool TableHasOrdered(Table table)
        {
            string query = "SELECT TOP 1 O.[datetime], B.[tableId] FROM orders AS O JOIN BillItems AS BI ON O.[id] = BI.orderId JOIN bills AS B ON B.[id] = BI.billId WHERE b.tableId = @tableId ORDER BY O.[datetime] DESC";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tableId", table.Id),
            };
            return ReadTableHasOrdered(ExecuteSelectQuery(query, sqlParameters));
        }
        private bool ReadTableHasOrdered(DataTable dataTable)
        {
            if (dataTable.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
