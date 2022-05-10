using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Subcategory
    {
        public int Id { get; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public Subcategory(int id, string name, Category category)
        {
            Id = id;
            Name = name;
            Category = category;
        }
    }
}
