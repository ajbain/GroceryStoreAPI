using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryStoreAPI.Models
{
    public enum DietType { GlutenFree, Vegan, Vegetarian, DairyFree}
    public enum GroceryLocation { Frozen, Meat, Deli, Bakery, Produce, Dairy, Snacks, Condiments}
    public class Ingredients
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int UPC { get; set; }
    }
}