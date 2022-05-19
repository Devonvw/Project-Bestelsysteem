using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BillItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public int BillId { get; set; }

        public BillItem(int id, int orderId, int billId)
        {
            Id = id;
            OrderId = orderId;
            BillId = billId;
        }

        public BillItem()
        {

        }

        public void AddBillItem(Bill bill, Order order)
        {
            // add billitems
        }

        public void DeleteBillItem(Bill bill, Order order)
        {
            // delete billitem
        }
    }
}
