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
        public Staff Staff { get; }
        public DateTime DateTime { get; }
        public string Comment { get; set; }
        public float TotalPrice { get; }
        public float LowBtwPrice { get; }
        public float HighBtwPrice { get; }
        public float Tip { get; set; }
        public bool Payed { get; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<Order> BillItems { get; }

        public Bill(int id, int tableId, Staff staff, DateTime dateTime, string comment, float totalPrice, float lowBtwPrice, float highBtwPrice, float tip, bool payed, PaymentMethod paymentMethod)
        {
            Id = id;
            TableId = tableId;
            Staff = staff;
            DateTime = dateTime;
            Comment = comment;
            TotalPrice = totalPrice;
            LowBtwPrice = lowBtwPrice;
            HighBtwPrice = highBtwPrice;
            Tip = tip;
            Payed = payed;
            PaymentMethod = paymentMethod;
        }
        public Bill()
        {

        }
    }
}
