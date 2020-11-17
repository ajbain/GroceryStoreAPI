using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryStoreAPI.Models
{

    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RecipeName { get; set; }
        public string Directions { get; set; }

       

        //public List<Ingredients> IngredientList = new List<Ingredients>();

        //List<Ingredients> IngredientsList()
        //{
        //    List<string> Ingredients = new List<string>();
       //ingredients.Add("Onions");
       // return Ingredients.
        //}
        public DietType dietType { get; set; }
        public bool hasDietTypeOptions { get; set; }
        public int TimeToPrepare { get; set; }

      

    }
  
}