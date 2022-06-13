using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;


namespace Controller
{
    public class OrderController
    {
        OrderDao orderDB;

        public OrderController()
        {
            orderDB = new OrderDao();
        }
        public List<OrderItem> GetOrderItemsForOverview(Bill bill)
        {
            return orderDB.GetOrderItemsForOverview(bill);
        }
        public void InsertOrder(Bill bill, Order order)
        {
            orderDB.InsertOrder(bill, order);
        }
        public void UpdateOrderItem(OrderItem orderItem)
        {
            orderDB.UpdateOrderItem(orderItem);
        }
        public void DeleteOrderItem(OrderItem orderItem)
        {
            orderDB.DeleteOrderItem(orderItem);
        }
    }
}
