using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class LoginController
    {
        LoginDao logindb;

        public LoginController()
        {
            logindb = new LoginDao();
        }

        public bool LoginCheck(Login userLogin)
        {
            List<Login> allUsers = GetAllUsers();

            foreach (Login user in allUsers)
            {
                if(user.UserName == userLogin.UserName && user.Password == HashAndSalt(userLogin.Password))
                {
                    return true;
                }
            }
            return false;
        }
        public List<Login> GetAllUsers()
        {
            List<Login> allUsers = logindb.GetAllUsers();
            return allUsers;
        }

        public string HashAndSalt(string password)
        {
            byte[] noSalt = new byte[0];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(noSalt);
            }

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: noSalt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 1000,
                numBytesRequested: 256 / 8));
            return hashed;
        }
        public void AddUser(Login newUser)
        {
            logindb.AddUser(newUser);
        }
    }
}
