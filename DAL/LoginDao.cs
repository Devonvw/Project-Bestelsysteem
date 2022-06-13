using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDao : BaseDao
    {
        public List<Login> GetAllUsers()
        {
            string query = "SELECT email, [password], employed FROM Staff";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Login> ReadTables(DataTable dataTable)
        {
            List<Login> Users = new List<Login>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Login user = new Login((string)dr["password"], (string)dr["email"], (bool)dr["employed"]);
                Users.Add(user);
            }
            return Users;
        }
    }
}
