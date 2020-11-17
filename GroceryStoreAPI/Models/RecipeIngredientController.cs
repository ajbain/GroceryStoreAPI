using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GroceryStoreAPI.Models
{
    public class RecipeIngredientController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]

        public async Task<IHttpActionResult> Create(RecipeIngredient recipeIngredient)
        {

            if (ModelState.IsValid)
            {
                Ingredients ingredients = await _context.Ingredients.FindAsync(recipeIngredient.IngredientID);
                Recipe recipe = await _context.Recipe.FindAsync(recipeIngredient.RecipeID);

                if(ingredients == null)
                {
                    return BadRequest("There are no ingredients here");
                }
                if (recipe == null)
                {
                    return BadRequest("There is no recipe here");
                }

                _context.RecipeIngredients.Add(recipeIngredient);
                await _context.SaveChangesAsync();
                return Ok();

            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            List<RecipeIngredient> recipeIngredients = await _context.RecipeIngredients.ToListAsync();



            return Ok(recipeIngredients);
        }

        //[HttpPut]
        //public async Task<IHttpActionResult> UpdateRecipeIngredient([FromUri] int id, [FromBody] RecipeIngredient model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    RecipeIngredient recipeIngredient = await _context.RecipeIngredients.FindAsync(id);

        //    if(recipeIngredient == null)
        //    {
        //        return NotFound();
        //    }
        //    recipeIngredient.N

        //}

    }
}
