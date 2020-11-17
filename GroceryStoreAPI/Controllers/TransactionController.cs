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
    public class TransactionController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]

        public async Task<IHttpActionResult> Create(Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                Ingredients ingredients = await _context.Ingredients.FindAsync(transaction.IngredientID);

                if(ingredients == null)
                {
                    return BadRequest("There are no ingredients here");

                }
                if (transaction.Quantity > ingredients.Quantity)
                {
                    return BadRequest($"There aren't enough left in stock! There are only {ingredients.Quantity} left.");
                }
                ingredients.Quantity -= transaction.Quantity;

                _context.Transaction.Add(transaction);
                await _context.SaveChangesAsync();
                return Ok();

            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Transaction> transactions = await _context.Transaction.ToListAsync();
            return Ok(transactions); 
        }
    }
}
