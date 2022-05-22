using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        public int Id { get; set; } 
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public Category Category { get; set; }
        public int SubcategoryId { get; set; } // subcategory class/enum
        public float PriceEx { get; set; }


        public MenuItem(int id, string shortName, string fullName, Category category, int subcategoryId, float priceEx)
        {
            Id = id;
            ShortName = shortName;
            FullName = fullName;
            Category = category;
            SubcategoryId = subcategoryId;
            PriceEx = priceEx;
        }

        public MenuItem()
        {

        }
    }
}
