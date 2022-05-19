using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model

{
    public class Login
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Login(string firstname, string lastname, string password)
        {
            UserName = firstname + lastname;
            Password = password;   
            Firstname = firstname;
            Lastname = lastname;
        }

        public Login()
        {
        }
    }
}
