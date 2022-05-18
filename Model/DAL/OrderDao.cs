﻿using System;
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
        // insert functions
        private void InsertOrder(Order order, Bill bill)
        {
            string query = "INSERT INTO Orders VALUES (@staffId, @datetime) SELECT SCOPE_IDENTITY() AS OrderId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("staffId", order.Staff),
                new SqlParameter("datetime", order.DateTime),
            };
            DataTable datatable = ExecuteSelectQuery(query, sqlParameters);
            order.Id = (int)datatable.Rows[0]["OrderId"];           
            InsertOrderItems(order);
            InsertBillItems(bill, order);
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

        private void InsertOrderItems(Order order)
        {
            foreach (OrderItem orderItem in order.OrderItems)
            {
                string query = "INSERT INTO OrderItems Values (@orderId, @menuItemId, @amount, @comment, @ready)";
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@orderId", order.Id),
                    new SqlParameter("@menuItemId", orderItem.MenuItem),
                    new SqlParameter("@amount", orderItem.Amount),
                    new SqlParameter("@comment", orderItem.Comment),
                    new SqlParameter("@ready", orderItem.Ready)
                };
                ExecuteEditQuery(query, sqlParameters);
            }
        }
                
        // update functions
        private void UpdateOrderItem(OrderItem orderItem)
        {
            string query = "UPDATE OrderItems SET amount=@amount, comment=@comment WHERE id=@id";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@amount", orderItem.Amount);
            sqlParameters[1] = new SqlParameter("comment", orderItem.Comment);
            sqlParameters[2] = new SqlParameter("id", orderItem.Id);
            ExecuteEditQuery(query, sqlParameters);
        }


        // delete functions
        private void DeleteOrderItem(OrderItem orderItem)
        {
            string query = "DELETE FROM OrderItems WHERE id=@id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", orderItem.Id);
            ExecuteEditQuery(query, sqlParameters);
        }
        private void DeleteOrder(Order order, BillItem billItem, Bill bill)
        {
            // delete an order
            foreach (OrderItem orderItem in order.OrderItems)
            {
                DeleteOrderItem(orderItem);
            }
            DeleteBillItems(bill, order);
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
