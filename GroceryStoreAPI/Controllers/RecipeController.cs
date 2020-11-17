using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GroceryStoreAPI.Controllers
{
    public class RecipeController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        // create
        [HttpPost]
        public async Task<IHttpActionResult> Create(Recipe recipe)

        {
            if (ModelState.IsValid)
            {
                _context.Recipe.Add(recipe);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState); 

        }
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            List<Recipe> recipe = await _context.Recipe.ToListAsync();



            return Ok(recipe);
        }
        // GET BY ID
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Recipe recipe = await _context.Recipe.FindAsync(id);
            if (recipe != null)
            {
                return Ok(recipe);
            }
            return NotFound();
        }
        // Update
        [HttpPut]
        public async Task<IHttpActionResult> UpdateRecipe([FromUri] int id, [FromBody] Recipe model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Recipe recipe = await _context.Recipe.FindAsync(id);

            if (recipe == null)
            {
                return NotFound();
            }

           // recipe.Name = model.Name;
            recipe.Directions = model.Directions;
            recipe.DietType = model.DietType;
            recipe.TimeToPrepare = model.TimeToPrepare;
            


            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok();
            }

            return InternalServerError();


        }

        // Delete

        [HttpDelete]
        public async Task<IHttpActionResult> DeleteRecipeById(int id)
        {
            Recipe recipe = await _context.Recipe.FindAsync(id);

            if (recipe == null)
            {
                return NotFound();
            }

            _context.Recipe.Remove(recipe);

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok();
            }

            return InternalServerError();
        }
    }
}
