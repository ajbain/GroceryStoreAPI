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
            

            // return unauthorized //403
            if (ModelState.IsValid)
            {
                _context.Recipe.Add(recipe);
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest(ModelState); //400

        }
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            List<Recipe> recipe = await _context.Recipe.ToListAsync();



            return Ok(recipe);
        }
    }
}
