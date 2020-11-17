using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroceryStoreAPI.Models
{
    public class RecipeIngredient
    {
       [Key]
       public int Id { get; set; }
        [ForeignKey(nameof(Recipe))]

        public int RecipeID { get; set; }
        public virtual Recipe Recipe { get; set; }

        [Required]
        [ForeignKey(nameof(Ingredients))]
        public int IngredientID { get; set; }

       
        public virtual Ingredients Ingredients { get; set; }
    }
}