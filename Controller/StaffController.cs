using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Text.RegularExpressions;


namespace Controller
{
    public class StaffController
    {
        static Regex validate_emailaddress = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$", RegexOptions.IgnoreCase);

        StaffDao menuDb;

        public StaffController()
        {
            menuDb = new StaffDao();
        }
        public List<Staff> GetAllStaff()
        {
            return menuDb.GetAllStaff();
        }
        public bool StaffExists(Staff staff)
        {
            return menuDb.StaffExists(staff);
        }
        public void AddStaff(Staff staff)
        {
            if (!StaffExists(staff)) ; //menuDb.AddStaff(staff);
            else throw new Exception("Er bestaat al een werknemer met deze naam.");
        }
        public void UpdateStaff(Staff staff)
        {
            if (string.IsNullOrEmpty(staff.FirstName)) throw new Exception("De voornaam is nog niet ingevuld");
            if (string.IsNullOrEmpty(staff.LastName)) throw new Exception("De achternaam is nog niet ingevuld");
            if (string.IsNullOrEmpty(staff.Email)) throw new Exception("De email is nog niet ingevuld");
            if (validate_emailaddress.IsMatch(staff.Email) != true) throw new Exception("Dit is geen geldige email");

            menuDb.UpdateStaff(staff);
        }
    }
}
