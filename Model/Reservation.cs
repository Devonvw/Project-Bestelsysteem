using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }  
        public int Persons { get; set; }    
        public int TableId { get; set; }

        public Reservation(int id, string name, DateTime dateTime, int persons, int tableId)
        {
            Id = id;
            Name = name;
            DateTime = dateTime;
            Persons = persons;
            TableId = tableId;
        }

        public Reservation()
        {
        }
    }

}
