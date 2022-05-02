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
    public class OrderDao : BaseDao
    {      
        public List<OrderItem> GetOrderItems()
        {
            string query = "SELECT student_id, student_name FROM [TABLE]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddOrder(Order order)
        {
            /*Add order to the bill (BillItems), also add to price*/
        }
        public void AddTip(float tip)
        {
            /*Add tip to the bill (Bill)*/
        }
        public void AddComment(string comment)
        {
            /*Add comment to the bill (Bill)*/
        }
        public void Payed(int paymentMethodId)
        {
            /*Set Payed bill to true (Bill) and add paymentMethod*/
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
