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
            string query = "SELECT * FROM Staff ORDER BY employed desc, firstName";
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
        public bool StaffExists(Staff staff)
        {
            string query = "SELECT * FROM Staff WHERE firstName = @firstname and lastName = @lastname";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@firstname", staff.FirstName),
                new SqlParameter("@lastname", staff.LastName),
            };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            
            if (dataTable == null) return false;
            else return true;
        }
        public void UpdateStaff(Staff staff)
        { 
            string query = "UPDATE Staff SET firstName = @firstName, lastName = @lastName, birthDate = @birthdate, roleId = @roleId, email = @email, employed = @employed WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = staff.Id },
                new SqlParameter("@firstName", SqlDbType.VarChar) { Value = staff.FirstName },
                new SqlParameter("@lastName", SqlDbType.VarChar) { Value = staff.LastName },
                new SqlParameter("@birthdate", SqlDbType.DateTime) { Value = staff.BirthDate },
                new SqlParameter("@roleId", SqlDbType.Int) { Value = staff.Role },
                new SqlParameter("@email", SqlDbType.VarChar) { Value = staff.Email },
                new SqlParameter("@employed", SqlDbType.Bit) { Value = staff.Employed },
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        private List<Staff> ReadTables(DataTable dataTable)
        {
            List<Staff> staffList = new List<Staff>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Staff staff = new Staff((int)dr["id"], dr["firstName"].ToString(), dr["lastName"].ToString(), DateTime.Parse(dr["birthDate"].ToString()), (Roles)(int)dr["roleId"], dr["email"].ToString(), dr["password"].ToString(), (bool)dr["employed"]);
                staffList.Add(staff);
            }
            return staffList;
        }

    }
}
