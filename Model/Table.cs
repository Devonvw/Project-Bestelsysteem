using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Table
    {
        public int Id { get; }
        public bool Occupied { get; }

        public Table(int id, bool occupied)
        {
            Id = id;
            Occupied = occupied;
        }
    }
}
