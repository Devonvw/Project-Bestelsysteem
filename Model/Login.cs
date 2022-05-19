﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model

{
    public class Login
    {
        
        public string UserName { get; set; }
        public string Password { get; set; }


        public Login(string password, string email)
        {
            UserName = email;
            Password = password;   
        }

        public Login()
        {
        }
    }
}
