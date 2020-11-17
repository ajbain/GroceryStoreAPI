using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroceryStoreAPI.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]

       public int IngredientID { get; set; }
        
        [ForeignKey(nameof(IngredientID))]

        public virtual Ingredients Ingredients { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOfTransaction { get; set; }
        public int Quantity { get; set;  }
    }
}