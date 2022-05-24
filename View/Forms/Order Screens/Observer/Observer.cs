using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View.Forms.Order_Screens.Observer
{
    public class Observer : IObserver
    {
        public string Name { get; set; }
        public Observer(string name, OrderStatus orderStatus)
        {
            Name = name;
            orderStatus.Register(this);
        }

        public void Update(OrderStatus orderStatus)
        {
            
        }

        public void UpdateOrderItems()
        {
            
        }
    }
}
