using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReservationDao : BaseDao
    {
        public List<Reservation> GetAllReservations()
        {
            string query = "SELECT [id], [name], [datetime], persons, tableId FROM reservation";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddReservation(Reservation reservation)
        {
            string query = "INSERT INTO reservation ([name], [datetime], persons, tableId) VALUES (@name, @datetime, @persons, @tableId);";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@name", reservation.Name),
                new SqlParameter("@datetime", reservation.DateTime),
                new SqlParameter("@persons", reservation.Persons),
                new SqlParameter("@tableId", reservation.TableId),
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Reservation> ReadTables(DataTable dataTable)
        {
            List<Reservation> Reservations = new List<Reservation>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Reservation reservation = new Reservation()
                {
                    Id = (int)dr["Id"],
                    Name = (string)dr["name"],
                    DateTime = (DateTime)dr["datetime"],
                    Persons = (int)dr["persons"],
                    TableId = (int)dr["tableId"],
                };
                Reservations.Add(reservation);
            }
            return Reservations;
        }
        public List<Reservation> GetReservationByName(Reservation reservation)
        {
            string query = "Select [id], [name], [datetime], persons, tableId from reservation where [name]=@name";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@name", reservation.Name);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Reservation> GetReservationsForTable(Reservation reservation)
        {
            string query = "Select [id], [name], [datetime], persons, tableId from reservation where tableId=@tableId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableId", reservation.TableId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Reservation> GetReservationByTime(Reservation reservation)
        {
            string query = "Select [id], [name], [datetime], persons, tableId from reservation where [datetime] between @FirstDatetime and @Lastdatetime";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@FirstDatetime", reservation.DateTime);
            sqlParameters[1] = new SqlParameter("@Lastdatetime", reservation.DateTime.AddDays(1));
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DeleteReservation(Reservation reservation)
        {
            string query = "DELETE FROM reservation WHERE [name]=@name AND [datetime]=@datetime AND [tableId]=@table";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@name", reservation.Name);
            sqlParameters[1] = new SqlParameter("@datetime", reservation.DateTime);
            sqlParameters[2] = new SqlParameter("@table", reservation.TableId);
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
