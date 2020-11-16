using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
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
       /* //Read
        [HttpGet]

        public async Task<IHttpActionResult> GetAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return Ok(products);
        }
        //Update
        [HttpPut]
        public async Task<IHttpActionResult> UpdateProduct([FromUri] int id, [FromBody] Product model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            Product product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound(); // 404
            }

            product.ProductName = model.ProductName;
            product.Quantity = model.Quantity;
            product.Price = model.Price;
            product.UPC = model.UPC;
            // product.Rating = model.Rating;

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok(); // 200
            }

            return InternalServerError(); // 500

            // 403 = ?? Forbidden (not authorized)

            // 418 = I'm a teapot (misc. or unknown error)
        }

        */
    }
}
