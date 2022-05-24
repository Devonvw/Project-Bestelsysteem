using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Controller;
using View.Forms.Order_Screens.Observer;

namespace View.Forms.Order_Screens
{
    public class OrderStatus : ISubject
    {
        public List<IObserver> observers;

        public Bill Bill { get; set; }

        public DateTime Timer { get; set; }

        public OrderStatus(Bill bill)
        {
            observers = new List<IObserver>();
            Bill = bill;
        }

        private OrderStatus(Bill bill, DateTime timer)
        {
            Bill = bill;
            Timer = timer;
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                OrderStatus orderStatus = new OrderStatus(Bill, Timer);
                observer.Update(orderStatus);
                observer.UpdateOrderItems();
            }             
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
