using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int Id { get; }
        public int TableId { get; } 
        public int Staff { get; } // Moet staff object worden
        public DateTime DateTime { get; }
        public List<OrderItem> OrderItems { get; }

        public Order(int id, int tableId, int staff, DateTime dateTime)
        {
            Id = id;
            TableId = tableId;
            Staff = staff;
            DateTime = dateTime;
            OrderItems = new List<OrderItem>();
        }

        public Order(int tableId, int staff, DateTime dateTime)
        {
            TableId = tableId;
            Staff = staff;
            DateTime = dateTime;
            OrderItems = new List<OrderItem>();
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
    }
}
