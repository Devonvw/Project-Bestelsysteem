using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LoginDao : BaseDao
    {
        public List<Login> GetAllUsers()
        {
            string query = "SELECT email, [password] FROM Staff";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        /*public void AddUser(Login login)
        {
            string query = "INSERT INTO Staff VALUES (@firstname, @lastname, @password, @email);";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@firstname", login.Firstname),
                new SqlParameter("@lastname", login.Lastname),
                new SqlParameter("@password", login.Password),
            };
            ExecuteEditQuery(query, sqlParameters);
        }*/

        private List<Login> ReadTables(DataTable dataTable)
        {
            List<Login> Users = new List<Login>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Login user = new Login()
                {
                    UserName = (string)dr["email"],
                    Password = (string)dr["password"],
                };
                Users.Add(user);
            }
            return Users;
        }
    }
}
