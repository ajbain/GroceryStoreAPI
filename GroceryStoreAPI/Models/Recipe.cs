using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryStoreAPI.Models
{
    public class Recipe
    {
        [Key]
        public string RecipeNum { get; set; }
        [Required]
        public string RecipeName { get; set; }
        public string Directions { get; set; }
        [Required]
        public List<Ingredients> _recipeIngredients = new List<Ingredients>();
        public DietType dietType { get; set; }
        public bool hasDietTypeOptions { get; set; }
        public int TimeToPrepare { get; set; }
       // public int TimeToCook { get; set; }

    }
   /* public Recipe(string recipenum, string recipename, string directions, List<Ingredients> ingredients, DietType dietType, bool hasDietTypeOptions)
    {
        //TeamPosition = teamPosition;
        RecipeNum = recipeNum;
        PokemonNickName = nickName;
        Level = level;
        PokemonType = pokemonType;
        SecondaryType = secondaryType;
        MoveOne = moveOne;
        MoveTwo = moveTwo;
        MoveThree = moveTwo;
        MoveFour = moveFour;
    }*/




}