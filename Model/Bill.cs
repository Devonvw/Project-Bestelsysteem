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
        public float TotalPriceEx { get; }
        public float Tip { get; }
        public bool Payed { get; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<Order> BillItems { get; }

        public Bill(int id, int tableId, Staff staff, DateTime dateTime, string comment, float totalPrice, float totalPriceEx, float tip, bool payed, PaymentMethod paymentMethod)
        {
            Id = id;
            TableId = tableId;
            Staff = staff;
            DateTime = dateTime;
            Comment = comment;
            TotalPrice = totalPrice;
            TotalPriceEx = totalPriceEx;
            Tip = tip;
            Payed = payed;
            PaymentMethod = paymentMethod;
        }
        public void AddOrder(Order order)
        {
            /*Add order to the bill (BillItems), also add to price*/
        }
        public void AddTip(float tip)
        {
            /*Add tip to the bill (Bill)*/
        }
        public void AddComment(string comment)
        {
            /*Add comment to the bill (Bill)*/
        }
        public void Pay(int paymentMethodId)
        {
            /*Set Payed bill to true (Bill) and add paymentMethod*/
        }
    }
}
