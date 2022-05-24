using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Forms.Order_Screens.Observer
{
    public interface IObserver
    {
        void Update(OrderStatus orderStatus);
        void UpdateOrderItems();
    }
}
