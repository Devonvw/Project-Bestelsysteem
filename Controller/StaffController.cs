using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class StaffController
    {
        StaffDao menuDb;

        public StaffController()
        {
            menuDb = new StaffDao();
        }
        public List<Staff> GetAllStaff()
        {
            return menuDb.GetAllStaff();
        }
        public void AddStaff(Staff staff)
        {
            menuDb.AddStaff(staff);
        }
        public void RemoveStaff(Staff staff)
        {
            menuDb.RemoveStaff(staff);
        }
    }
}
