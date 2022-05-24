using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        public int Id { get; } 
        public string ShortName { get; }
        public string FullName { get; }
        public Category Category { get; }
        public int SubcategoryId { get; }
        public float PriceEx { get; }
        public bool InMenu { get; }
        public int Stock { get; set; }

        public MenuItem(string shortName, string fullName, Category category, int subcategoryId, float priceEx, bool inMenu, int stock)
        {
            ShortName = shortName;
            FullName = fullName;
            Category = category;
            SubcategoryId = subcategoryId;
            PriceEx = priceEx;
            InMenu = inMenu;
            Stock = stock;
        }
        public MenuItem(int id, string shortName, string fullName, Category category, int subcategoryId, float priceEx, bool inMenu, int stock)
        {
            Id = id;
            ShortName = shortName;
            FullName = fullName;
            Category = category;
            SubcategoryId = subcategoryId;
            PriceEx = priceEx;
            InMenu = inMenu;
            Stock = stock;
        }
    }
}
