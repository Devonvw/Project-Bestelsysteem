using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new BestelsysteemUI());
            //Application.Run(new Forms.Management());
            //Application.Run(new Forms.BillScreen(new Table(1, true)));
            Application.Run(new Forms.OrderScreenParent());
        }
    }
}
