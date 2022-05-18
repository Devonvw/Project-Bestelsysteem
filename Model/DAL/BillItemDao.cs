using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using Model;

namespace Model
{
    public class BillItemDao : BaseDao
    {
        private List<BillItem> ReadTables(DataTable dataTable)
        {
            List<BillItem> billItems = new List<BillItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                BillItem billItem = new BillItem()
                {
                    Id = (int)dr["Id"],
                    OrderId = (int)dr["orderId"],
                    BillId = (int)dr["BillId"],
                };
                billItems.Add(billItem);
            }
            return billItems;
        }

        public List<BillItem> GetBillItems(Bill bill)
        {
            string query = "SELECT FROM BillItems WHERE billId=@billId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@billId", bill.Id);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }        
    }
}
