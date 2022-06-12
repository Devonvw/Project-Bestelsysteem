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
        public List<IObserver> Observers;
        private TableController tableController;

        public BillController()
        {
            billDB = new BillDao();
            Observers = new List<IObserver>();
            tableController = new TableController();
        }
        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
        private void AlertObservers()
        {
            foreach (IObserver observer in Observers)
            {
                observer.UpdateForm();
            }
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
            if (bill.PaymentMethod == PaymentMethod.None) throw new Exception("Kies een betaalmethode");

            billDB.CloseBill(bill);
            tableController.ChangeOccupied(new Table(bill.TableId, false));
            AlertObservers();
        }

        public void CreateBill(Table table, Staff staff)
        {            
            billDB.CreateBill(table, staff);
            AlertObservers();
        }

        public Bill CheckForOpenBillOnTable(Table table)
        {
            Bill bill = billDB.CheckForOpenBillOnTable(table);
            return bill;
        }
        public bool BillExist(Table table)
        {
            return billDB.BillExist(table);
        }
    }
}
