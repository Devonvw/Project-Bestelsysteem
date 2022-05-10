using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation
    {
        public int Id { get; }
        public DateTime DateTime { get; }
        public Table Table { get; }
        public int Persons { get; }

        public Reservation(int id, DateTime dateTime, Table table, int persons)
        {
            Id = id;
            DateTime = dateTime;
            Table = table;
            Persons = persons;
        }
    }
}
