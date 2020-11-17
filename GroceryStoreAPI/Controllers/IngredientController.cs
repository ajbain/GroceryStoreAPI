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
    public class IngredientController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        // Create
        [HttpPost]
        public async Task<IHttpActionResult> Post(Ingredients ingredient)
        {


            if (ModelState.IsValid)
            {
              
                _context.Ingredients.Add(ingredient);
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest(ModelState); 
        }

        // Read
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            List<Ingredients> Ingredients = await _context.Ingredients.ToListAsync();



            return Ok(Ingredients);
        }
        // GET BY ID
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Ingredients ingredient = await _context.Ingredients.FindAsync(id);
            if (ingredient != null)
            {
                return Ok(ingredient);
            }
            return NotFound(); 
        }
        // Update
        [HttpPut]
        public async Task<IHttpActionResult> UpdateIngredient([FromUri] int id, [FromBody] Ingredients model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Ingredients ingredient = await _context.Ingredients.FindAsync(id);

            if (ingredient == null)
            {
                return NotFound(); 
            }

            ingredient.Name = model.Name;
            ingredient.Quantity = model.Quantity;
            ingredient.Price = model.Price;
            ingredient.UPC = model.UPC;
            ingredient.Location = model.Location;


            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok(); 
            }

            return InternalServerError(); 

           
        }

        // Delete

        [HttpDelete]
        public async Task<IHttpActionResult> DeleteIngredientById(int id)
        {
            Ingredients ingredient = await _context.Ingredients.FindAsync(id);

            if (ingredient == null)
            {
                return NotFound(); 
            }

            _context.Ingredients.Remove(ingredient);

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok(); 
            }

            return InternalServerError(); 
        }
    }
}
