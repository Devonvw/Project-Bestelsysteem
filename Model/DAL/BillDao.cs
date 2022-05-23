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

namespace Model
{
    public class BillDao : BaseDao
    {
        const float highBtw = 1.21F;
        const float lowBtw = 1.09F;

        public List<OrderItem> GetOrderItems(Bill bill)
        {
            string query = "SELECT OI.*, MI.id as menuItemId, MI.shortName, MI.fullName, MI.categoryId, MI.subcategoryId, MI.priceEx FROM BillItems AS BI INNER JOIN Orders AS O ON BI.orderId = O.id INNER JOIN OrderItems AS OI ON O.id = OI.orderId INNER JOIN MenuItems AS MI ON OI.menuItemId = MI.id WHERE BI.billId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = bill.Id }
            };
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        public Bill GetCurrentBillByTable(Table table)
        {
            string query = "SELECT TOP 1 * FROM Bills AS B INNER JOIN Staff AS S ON B.staffId = S.id WHERE tableId = @tableId ORDER BY [datetime] DESC";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tableId", SqlDbType.Int) { Value = table.Id }
            };
            return ReadBill(ExecuteSelectQuery(query, sqlParameters));
        }

        //public void GetLastOrderItems(Bill bill)
        //{
        //    
        //}

        private (float totalPrice, float totalPriceEx) GetTotalBillPrice(int billId)
        {
            string query = "SELECT Cast(SUM(MI.priceEx * OI.amount * CASE WHEN SC.highBtw = 'true' THEN @highBtw ELSE @lowBtw END) AS DECIMAL(5, 2)) as totalPrice, SUM(MI.priceEx * OI.amount) as totalPriceEx FROM BillItems AS BI INNER JOIN Orders AS O ON BI.orderId = O.id INNER JOIN OrderItems AS OI ON O.id = OI.orderId INNER JOIN MenuItems AS MI ON OI.menuItemId = MI.id INNER JOIN Subcategory AS SC ON MI.subcategoryId = SC.id WHERE BI.billId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@highBtw", SqlDbType.Float) { Value = highBtw },
                new SqlParameter("@lowBtw", SqlDbType.Float) { Value = lowBtw },
                new SqlParameter("@id", SqlDbType.Int) { Value = billId }
            };
            DataTable dt = ExecuteSelectQuery(query, sqlParameters);

            if (string.IsNullOrEmpty(dt.Rows[0]["totalPrice"].ToString()) || string.IsNullOrEmpty(dt.Rows[0]["totalPriceEx"].ToString())) return (totalPrice: 0, totalPriceEx: 0);

            return (totalPrice: float.Parse(dt.Rows[0]["totalPrice"].ToString()), totalPriceEx: float.Parse(dt.Rows[0]["totalPriceEx"].ToString()));
        }

        public void CloseBill(Bill bill)
        {
            /*Close the bill (Update)*/

            string query = "UPDATE Bills SET payed = 'true', paymentMethodId = @paymentMethodId, tip = @tip, comment = @comment WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@paymentMethodId", SqlDbType.Int) { Value = bill.PaymentMethod },
                new SqlParameter("@tip", SqlDbType.Int) { Value = bill.Tip },
                new SqlParameter("@comment", SqlDbType.VarChar ) { Value = bill.Comment },
                new SqlParameter("@id", SqlDbType.Int) { Value = bill.Id },

            };

            ExecuteEditQuery(query, sqlParameters);
        }
        public List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {

                OrderItem orderItem = new OrderItem((int)dr["id"], (int)dr["orderId"], new MenuItem((int)dr["menuItemId"], dr["shortName"].ToString(), dr["fullName"].ToString(), (Category)(int)dr["categoryId"], (SubCategory)(int)dr["subcategoryId"], float.Parse(dr["priceEx"].ToString())), (int)dr["amount"], dr["comment"].ToString(), (bool)dr["isReady"]);
                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        private Bill ReadBill(DataTable dataTable)
        {
            DataRow firstRow = dataTable.Rows[0];

            (float totalPrice, float totalPriceEx) totalPrice = GetTotalBillPrice((int)firstRow["id"]);

            Bill bill = new Bill((int)firstRow["id"], (int)firstRow["tableId"], new Staff((int)firstRow["staffId"], firstRow["firstName"].ToString(), firstRow["lastName"].ToString(), DateTime.Parse(firstRow["birthDate"].ToString()), (Roles)(int)firstRow["staffId"], firstRow["password"].ToString(), firstRow["email"].ToString()), DateTime.Parse(firstRow["datetime"].ToString()), firstRow["comment"].ToString(), totalPrice.totalPrice, totalPrice.totalPriceEx, float.Parse(firstRow["tip"].ToString()), (bool)firstRow["payed"], (PaymentMethod)(int)firstRow["paymentMethodId"]);
            return bill;
        }

        public void CreateBill(Table table, Staff staff)
        {
            string query = "INSERT INTO Bills (tableId, staffId) VALUES (@tableID, @staffId)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tableID", table.Id),
                new SqlParameter("@staffId", staff.Id),
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public Bill CheckForOpenBillOnTable(Table table)
        {
            string query = "SELECT * FROM Bills WHERE tableId = @tableId AND Payed = 'false'";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tableId", SqlDbType.Int) { Value = table.Id }
            };
            return ReadBill(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
