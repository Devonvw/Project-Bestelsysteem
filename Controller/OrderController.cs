using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class OrderController
    {
        OrderDao orderDB;

        public OrderController()
        {
            orderDB = new OrderDao();
        }

        public void InsertOrder(Bill bill, Order order)
        {
            orderDB.InsertOrder(bill, order);
        }

        public void InsertBillItems(Bill bill, Order order)
        {
            orderDB.InsertBillItems(bill, order);
        }

        public void InsertOrderItems(Order order)
        {
            orderDB.InsertOrderItems(order);
        }

        public void UpdateOrderItem(OrderItem orderItem)
        {
            orderDB.UpdateOrderItem(orderItem);
        }

        public void DeleteOrderItem(OrderItem orderItem)
        {
            orderDB.DeleteOrderItem(orderItem);
        }

        public void DeleteOrder(Bill bill, Order order)
        {
            orderDB.DeleteOrder(bill, order);
        }

        //public void GetLastOrder(Bill bill)
        //{
        //    orderDB.GetLastOrder(bill);
        //}
    }
}
