using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItem
    {
        public int Id { get; } 
        public int OrderId { get; }
        public MenuItem MenuItem { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public bool Ready { get; set; }
        public Course Course { get; set; }
        public OrderItem(int id, int orderId, MenuItem menuItem, int amount, string comment, bool ready, Course course)
        {
            Id = id;
            OrderId = orderId;
            MenuItem = menuItem;
            Comment = comment;
            Ready = ready;
            Course = course;
            Amount = amount;
        }
        public OrderItem(int orderId, MenuItem menuItem, int amount, string comment, Course course)
        {
            OrderId = orderId;
            MenuItem = menuItem;
            Comment = comment;
            Ready = false;
            Course = course;
            Amount = amount;
        }
    }
}
