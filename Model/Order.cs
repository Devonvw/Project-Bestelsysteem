using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int Id { get; set; }
        public int Staff { get; set; } // Moet staff object worden
        public DateTime DateTime { get; set; } //
        public List<OrderItem> OrderItems { get; set; }

        public Order(int id, int staff, DateTime dateTime)
        {
            Staff = staff;
            DateTime = dateTime;
            OrderItems = new List<OrderItem>();
        }

        public Order(int staff, DateTime dateTime)
        {
            Staff = staff;
            DateTime = dateTime;
            OrderItems = new List<OrderItem>();
        }

        public Order()
        {
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
        public void RemoveOrderItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }
    }
}
