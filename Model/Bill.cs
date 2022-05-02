using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bill
    {
        public int Id { get; }
        public int TableId { get; }
        public int Staff { get; } // Moet staff object worden
        public DateTime DateTime { get; }
        public string Comment { get; set; }
        public float Price { get; }
        public float Tip { get; }
        public bool Payed { get; }
        public int PaymentMethodId { get; }
        public List<Order> BillItems { get; }

        public Bill(int id, int tableId, int staff, DateTime dateTime, string comment, float price, float tip, bool payed, int paymentMethodId)
        {
            Id = id;
            TableId = tableId;
            Staff = staff;
            DateTime = dateTime;
            Comment = comment;
            Price = price;
            Tip = tip;
            Payed = payed;
            PaymentMethodId = paymentMethodId;
        }
        public Bill(int tableId, DateTime dateTime, string comment, float price, float tip, bool payed, int paymentMethodId)
        {
            TableId = tableId;
            DateTime = dateTime;
            Comment = comment;
            Price = price;
            Tip = tip;
            Payed = payed;
            PaymentMethodId = paymentMethodId;
        }
    }
}
