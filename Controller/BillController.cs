﻿using System;
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

        public BillController()
        {
            billDB = new BillDao();
            Observers = new List<IObserver>();
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
            if (bill.Comment.Length > 255) throw new Exception("De opmerking is langer dan 255 letters");
            if (bill.PaymentMethod == PaymentMethod.None) throw new Exception("Kies een betaalmethode");

            billDB.CloseBill(bill);
            AlertObservers();
        }

        public void CreateBill(Table table, Staff staff)
        {            
            billDB.CreateBill(table, staff);
        }

        public Bill CheckForOpenBillOnTable(Table table)
        {
            Bill bill = billDB.CheckForOpenBillOnTable(table);
            return bill;
        }

        //public List<OrderItem> GetLastOrderItems(Bill bill)
        //{
        //    billDB.GetLastOrderItems(Bill bill);
        //}
    }
}
