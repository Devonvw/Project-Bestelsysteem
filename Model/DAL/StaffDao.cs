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
            string query = "INSERT INTO staff (firstName, lastName, birthDate, roleId, [password], [email], employed) VALUES (@firstname, @lastname, @birthDate, @roleId, @password, @email, @employed);";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@firstname", staff.FirstName),
                new SqlParameter("@lastname", staff.LastName),
                new SqlParameter("@password", staff.Password),
                new SqlParameter("@birthDate", staff.BirthDate),
                new SqlParameter("@roleId", staff.Role),
                new SqlParameter("@email", staff.Email),
                new SqlParameter("@employed", true),
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
        public void UpdateStaff(Staff staff)
        { 
            string query = "UPDATE Staff SET firstName = @firstName, lastName = @lastName, birthDate = @birthdate, roleId = @roleId, email = @email WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = staff.Id },
                new SqlParameter("@firstName", SqlDbType.VarChar) { Value = staff.FirstName },
                new SqlParameter("@lastName", SqlDbType.VarChar) { Value = staff.LastName },
                new SqlParameter("@birthdate", SqlDbType.DateTime) { Value = staff.BirthDate },
                new SqlParameter("@roleId", SqlDbType.Int) { Value = staff.Role },
                new SqlParameter("@email", SqlDbType.VarChar) { Value = staff.Email },
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
        public void UpdateEmployed(Staff staff)
        {
            string query = "UPDATE Staff SET employed = @employed WHERE firstName = @firstName, lastName = @lastName, birthDate = @birthdate";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@firstName", SqlDbType.VarChar) { Value = staff.FirstName },
                new SqlParameter("@lastName", SqlDbType.VarChar) { Value = staff.LastName },
                new SqlParameter("@birthdate", SqlDbType.DateTime) { Value = staff.BirthDate },
                new SqlParameter("@employed", true)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
