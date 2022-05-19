using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class BillController
    {
        BillDao billDB;

        public BillController()
        {
            billDB = new BillDao();
        }

        public List<OrderItem> GetOrderItems(Bill bill)
        {
            return billDB.GetOrderItems(bill);
        }
        public Bill GetCurrentBillByTable(Table table)
        {
            return billDB.GetCurrentBillByTable(table);
        }
        public void CloseBill(Bill bill)
        {
            billDB.CloseBill(bill);
        }
    }
}
