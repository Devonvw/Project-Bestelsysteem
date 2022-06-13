using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Table
    {

        public int Id { get; set; }
        public bool Occupied { get; set; }
        public DateTime TimeSeated { get; set; }
        public DateTime LastOrdered { get; set; }

        public Table(int id, bool occupied, DateTime timeSeated)
        {
            Id = id;
            Occupied = occupied;
            TimeSeated = timeSeated;
        }

        public Table()
        {
        }
        public Table(int id, bool occupied)
        {
            Id = id;
            Occupied = occupied;
        }
    }
}
