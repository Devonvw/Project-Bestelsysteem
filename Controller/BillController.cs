using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            if (bill.Comment.Length > 255) throw new Exception("De opmerking is langer dan 255 letters");
            if (bill.PaymentMethod == PaymentMethod.None) throw new Exception("Kies een betaalmethode");

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
