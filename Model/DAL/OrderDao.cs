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
    public class OrderDao : BaseDao
    {
        private List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
            // read all orderitems from the database
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem((int)dr["id"], (int)dr["orderId"], new MenuItem((int)dr["menuItemId"], dr["shortName"].ToString(), dr["fullName"].ToString(), (Category)(int)dr["categoryId"], (int)dr["subcategoryId"], (float)dr["priceEx"]), (int)dr["amount"], dr["comment"].ToString(), (bool)dr["ready"]);
                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        private List<Order> ReadOrders(DataTable dataTable)
        {
            // read all orders from the database
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order((int)dr["id"], (int)dr["staffId"], (DateTime)dr["dateTime"]);
                orders.Add(order);
            }
            return orders;
        }

        private void InsertOrder(Order order)
        {
            string query = "INSERT INTO Orders VALUES (@staffId, @datetime) SELECT SCOPE_IDENTITY() AS OrderId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("staffId", order.Staff),
                new SqlParameter("datetime", order.DateTime),
            };
            ExecuteSelectQuery(query, sqlParameters);                       
            InsertOrderItems(order);
            // nog niet GOED
        }

        private void InsertOrderItems(Order order)
        {
            foreach (OrderItem orderItem in order.OrderItems)
            {
                string query = "INSERT INTO OrderItems Values (@orderId, @menuItemId, @amount, @comment, @ready)";
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("orderId", order.Id),
                    new SqlParameter("@menuItemId", orderItem.MenuItem),
                    new SqlParameter("amount", orderItem.Amount),
                    new SqlParameter("comment", orderItem.Comment),
                    new SqlParameter("ready", orderItem.Ready)
                };
                ExecuteEditQuery(query, sqlParameters);
            }
        }

        private void UpdateOrderItem(OrderItem orderItem)
        {
            string query = "UPDATE OrderItems SET amount=@amount, comment=@comment WHERE id=@id";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@amount", orderItem.Amount);
            sqlParameters[1] = new SqlParameter("comment", orderItem.Comment);
            sqlParameters[2] = new SqlParameter("id", orderItem.Id);
            ExecuteEditQuery(query, sqlParameters);
        }

        private void DeleteOrderItem(OrderItem orderItem)
        {
            string query = "DELETE FROM OrderItems WHERE id=@id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", orderItem.Id);
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
