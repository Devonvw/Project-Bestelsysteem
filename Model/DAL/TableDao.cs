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
            string query = "SELECT [id], occupied FROM Tables";
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
                tables.Add(table);
            }
            return tables;
        }
    }
}
