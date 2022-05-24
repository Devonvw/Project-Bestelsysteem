using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Forms.Order_Screens.Observer;

namespace View.Forms.Order_Screens
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void Notify();
        void Unregister(IObserver observer);
    }
}
