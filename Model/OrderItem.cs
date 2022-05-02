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
        public int MenuItemId { get; set; } //Needs to be product object
        public int Amount { get; set; }
        public string Comment { get; set; }
        public bool Ready { get; set; }
        public string CourseId { get; set; }
        public OrderItem(int id, int orderId, int menuItemId, int amount, string comment, bool ready, string courseId)
        {
            Id = id;
            OrderId = orderId;
            MenuItemId = menuItemId;
            Comment = comment;
            Ready = ready;
            CourseId = courseId;
        }
        public OrderItem(int orderId, int menuItemId, string comment, string courseId)
        {
            OrderId = orderId;
            MenuItemId = menuItemId;
            Comment = comment;
            Ready = false;
            CourseId = courseId;
        }
    }
}
