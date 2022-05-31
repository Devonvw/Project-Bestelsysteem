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
            string query = "SELECT SUM(OI.amount) as totalAmount, (SUM(OI.amount) * MI.priceInc) as totalPrice, MI.id as menuItemId, MI.priceInc, MI.shortName, MI.fullName, MI.categoryId, MI.subcategoryId, MI.priceEx, MI.stock, MI.inMenu, SC.highBtw FROM BillItems AS BI INNER JOIN Orders AS O ON BI.orderId = O.id INNER JOIN OrderItems AS OI ON O.id = OI.orderId INNER JOIN (SELECT MI.id, MI.shortName, MI.fullName, MI.categoryId, MI.subcategoryId, MI.priceEx, MI.stock, MI.inMenu, Cast(SUM(MI.priceEx * CASE WHEN SC.highBtw = 'true' THEN @highBtw ELSE @lowBtw END) AS DECIMAL(5, 2)) as priceInc FROM MenuItems as MI INNER JOIN Subcategory as SC ON MI.subcategoryId = SC.id GROUP BY MI.id, MI.shortName, MI.fullName, MI.categoryId, MI.subcategoryId, MI.priceEx, MI.stock, MI.inMenu ) MI ON OI.menuItemId = MI.id INNER JOIN Subcategory as SC ON MI.subcategoryId = SC.id WHERE BI.billId = @id GROUP BY MI.id, MI.shortName, Mi.fullName, MI.categoryId, MI.subcategoryId, MI.priceEx, MI.priceInc, MI.stock, MI.inMenu, SC.highBtw";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@highBtw", SqlDbType.Float) { Value = highBtw },
                new SqlParameter("@lowBtw", SqlDbType.Float) { Value = lowBtw },
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

        public Bill GetCurrentOpenBillByTable(Table table)
        {
            string query = "SELECT TOP 1 * FROM Bills AS B INNER JOIN Staff AS S ON B.staffId = S.id WHERE tableId = @tableId AND payed = 'false' ORDER BY [datetime] DESC";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tableId", SqlDbType.Int) { Value = table.Id }
            };
            return ReadBill(ExecuteSelectQuery(query, sqlParameters));
        }

        private (float totalPrice, float lowBtwPrice, float highBtwPrice) GetTotalBillPrice(int billId)
        {
            string query = "SELECT Cast(SUM(MI.priceEx * OI.amount * CASE WHEN SC.highBtw = 'true' THEN @highBtw ELSE @lowBtw END) AS DECIMAL(5, 2)) as totalPrice, Cast(SUM(MI.priceEx * OI.amount * CASE WHEN SC.highBtw = 'true' THEN 0 ELSE @lowBtwPer END) AS DECIMAL(5, 2)) as lowBtwPrice, Cast(SUM(MI.priceEx * OI.amount * CASE WHEN SC.highBtw = 'true' THEN @highBtwPer ELSE 0 END) AS DECIMAL(5, 2)) as highBtwPrice FROM BillItems AS BI INNER JOIN Orders AS O ON BI.orderId = O.id INNER JOIN OrderItems AS OI ON O.id = OI.orderId INNER JOIN MenuItems AS MI ON OI.menuItemId = MI.id INNER JOIN Subcategory AS SC ON MI.subcategoryId = SC.id WHERE BI.billId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@highBtw", SqlDbType.Float) { Value = highBtw },
                new SqlParameter("@lowBtw", SqlDbType.Float) { Value = lowBtw },
                new SqlParameter("@highBtwPer", SqlDbType.Float) { Value = highBtw - 1 },
                new SqlParameter("@lowBtwPer", SqlDbType.Float) { Value = lowBtw - 1 },
                new SqlParameter("@id", SqlDbType.Int) { Value = billId }
            };
            DataTable dt = ExecuteSelectQuery(query, sqlParameters);

            if (string.IsNullOrEmpty(dt.Rows[0]["totalPrice"].ToString()) || string.IsNullOrEmpty(dt.Rows[0]["lowBtwPrice"].ToString()) || string.IsNullOrEmpty(dt.Rows[0]["highBtwPrice"].ToString())) return (totalPrice: 0, lowBtwPrice: 0, highBtwPrice: 0);

            return (totalPrice: float.Parse(dt.Rows[0]["totalPrice"].ToString()), lowBtwPrice: float.Parse(dt.Rows[0]["lowBtwPrice"].ToString()), highBtwPrice: float.Parse(dt.Rows[0]["highBtwPrice"].ToString()));
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
        public List<OrderItem> ReadOrderItems(DataTable dataTable)        {
            List<OrderItem> orderItems = new List<OrderItem>();
            int index = 1;

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem(index, new MenuItem((int)dr["menuItemId"], dr["shortName"].ToString(), dr["fullName"].ToString(), (Category)(int)dr["categoryId"], (SubCategory)(int)dr["subcategoryId"], float.Parse(dr["priceEx"].ToString()), (int)dr["stock"], (bool)dr["inMenu"]), (int)dr["totalAmount"], float.Parse(dr["totalPrice"].ToString()));
                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        private Bill ReadBill(DataTable dataTable)
        {
            DataRow firstRow = dataTable.Rows[0];

            (float totalPrice, float lowBtwPrice, float highBtwPrice) totalPrice = GetTotalBillPrice((int)firstRow["id"]);

            Bill bill = new Bill((int)firstRow["id"], (int)firstRow["tableId"], new Staff((int)firstRow["staffId"], firstRow["firstName"].ToString(), firstRow["lastName"].ToString(), DateTime.Parse(firstRow["birthDate"].ToString()), (Roles)(int)firstRow["staffId"], firstRow["email"].ToString(), firstRow["password"].ToString()), DateTime.Parse(firstRow["datetime"].ToString()), firstRow["comment"].ToString(), totalPrice.totalPrice, totalPrice.lowBtwPrice, totalPrice.highBtwPrice, float.Parse(firstRow["tip"].ToString()), (bool)firstRow["payed"], (PaymentMethod)(int)firstRow["paymentMethodId"]);
            return bill;
        }

        public void CreateBill(Table table, Staff staff)
        {
            string query = "INSERT INTO Bills (tableId, staffId, tip, payed) VALUES (@tableID, @staffId, 0, 'false')";
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
