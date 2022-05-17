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
        public void InsertBillItems(Bill bill, Order order)
        {
            string query = "INSERT INTO BillItems VALUES (@orderId, @billId)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter("@orderId", order.Id),
                    new SqlParameter("@billId", bill.Id)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteBillItems(Bill bill, Order order)
        {
            string query = "DELETE FROM BillItems WHERE billId=@billId AND orderId=@orderId";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@billId", bill.Id);
            sqlParameters[1] = new SqlParameter("@orderId", order.Id);
            ExecuteEditQuery(query, sqlParameters);
        }

        
    }
}
