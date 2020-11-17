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
        public int RecipeID { get; set; }
        [ForeignKey(nameof(RecipeID))]

        [Required]
        public int IngredientID { get; set; }

        [ForeignKey(nameof(IngredientID))]
        public virtual Ingredients Ingredients { get; set; }
    }
}