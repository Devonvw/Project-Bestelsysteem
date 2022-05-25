using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StaffDao : BaseDao
    {

        //staff nog niet kloppend gemaakt
        public List<Staff> GetAllStaff()
        {
            string query = "SELECT * FROM Staff ORDER BY firstName";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddStaff(Staff staff)
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@firstname", staff.FirstName),
                new SqlParameter("@lastname", staff.LastName),
                new SqlParameter("@password", staff.Password),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void RemoveStaff(Staff staff)
        {
            string query = "DELETE FROM Staff WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = staff.Id },
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Staff> ReadTables(DataTable dataTable)
        {
            List<Staff> staffList = new List<Staff>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Staff staff = new Staff((int)dr["id"], dr["firstName"].ToString(), dr["lastName"].ToString(), DateTime.Parse(dr["birthDate"].ToString()), (Roles)(int)dr["roleId"], dr["email"].ToString(), dr["password"].ToString());
                staffList.Add(staff);
            }
            return staffList;
        }

    }
}
