using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroceryStoreAPI.Models
{

    public enum DietType { GlutenFree, Vegan, Vegetarian, DairyFree }
    public enum GroceryLocation { Frozen, Meat, Deli, Bakery, Produce, Dairy, Snacks, Condiments }

    public class Ingredients
        {
              [Key]
              public int Id { get; set; }
              [Required]
              public string Name { get; set; }
             [Required]

             public int Quantity { get; set; }
             [Required]

             public double Price { get; set; }
              [Required]

             public int UPC { get; set; }
        }
    
}