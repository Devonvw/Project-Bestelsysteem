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
        public string ShortName { get; set;  }
        public string FullName { get; set; }
        public Category Category { get; set;  }
        public SubCategory SubCategory { get; set; }
        public float PriceEx { get; set; }
        public int Stock { get; set; }
        public bool InMenu { get; set;  }

        public MenuItem(string shortName, string fullName, Category category, SubCategory subCategory, float priceEx, int stock, bool inMenu)
        {
            ShortName = shortName;
            FullName = fullName;
            Category = category;
            SubCategory = subCategory;
            PriceEx = priceEx;
            Stock = stock;
            InMenu = inMenu;
        }
        public MenuItem(int id, string shortName, string fullName, Category category, SubCategory subCategory, float priceEx, int stock, bool inMenu)
        {
            Id = id;
            ShortName = shortName;
            FullName = fullName;
            Category = category;
            SubCategory = subCategory;
            PriceEx = priceEx;
            Stock = stock;
            InMenu = inMenu;
        }
        public MenuItem()
        {

        }
    }
}
