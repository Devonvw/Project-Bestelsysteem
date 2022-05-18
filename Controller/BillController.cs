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
            List<OrderItem> orderItems = billDB.GetOrderItems(bill);
            return orderItems;
        }
        public Bill GetCurrentBillByTable(Table table)
        {
            Bill bill = billDB.GetCurrentBillByTable(table);
            return bill;
        }
        public void CloseBill(Bill bill)
        {
            billDB.CloseBill(bill);
        }

        public void CreateBill(Bill bill, Staff staff)
        {
            billDB.CreateBill(bill, staff);
        }

        public Bill CheckForOpenBillOnTable(Table table)
        {
            Bill bill = billDB.CheckForOpenBillOnTable(table);
            return bill;
        }
    }
}
