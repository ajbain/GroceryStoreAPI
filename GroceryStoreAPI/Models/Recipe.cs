using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryStoreAPI.Models
{

    public class Recipe
    {
        [Key]
        public int RecipeNum { get; set; }
        [Required]
       // public string Name { get; set; }
        public string Directions { get; set; }

        public DietType DietType { get; set; }
        public bool HasDietTypeOptions { get; set; }
        public int TimeToPrepare { get; set; }

      

    }
  
}