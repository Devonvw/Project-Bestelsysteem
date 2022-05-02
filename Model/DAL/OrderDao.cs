using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using Model;

namespace Model
{
    public class BillDao : BaseDao
    {      
        public List<OrderItem> GetOrderItems()
        {
            string query = "SELECT student_id, student_name FROM [TABLE]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            /*foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem student = new OrderItem((int)dr["Id"]);
                students.Add(student);
            }*/
            return orderItems;
        }
    }
}
