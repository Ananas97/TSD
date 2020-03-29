using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;
using YummyRestApi.Models;

namespace YummyRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeItemsController : ControllerBase
    {
        private readonly RecipeContext _context;

        public RecipeItemsController(RecipeContext context)
        {
            _context = context;
        }

        // GET: api/RecipeItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecipeItem>>> GetRecipeItems()
        {
            return await _context.RecipeItems.ToListAsync();
           // return await _context.RecipeItems
           //.Select(x => ItemToDTO(x))
           //.ToListAsync();
        }

        // GET: api/RecipeItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeItem>> GetRecipeItem(int id)
        {
            var recipeItem = await _context.RecipeItems.FindAsync(id);

            if (recipeItem == null)
            {
                return NotFound();
            }

            return recipeItem;
        }

        // PUT: api/RecipeItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecipeItem(int id, RecipeItem recipeItem)
        {
            if (id != recipeItem.ID)
            {
                return BadRequest();
            }

            _context.Entry(recipeItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RecipeItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<RecipeItem>> PostRecipeItem([Bind(include: "Name, Time, Difficulty, NumberOfLikes, Ingredients, Process, TipsAndTricks")] RecipeItem recipeItem)
        {
            _context.RecipeItems.Add(recipeItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetRecipeItem", new { id = recipeItem.ID }, recipeItem);
            return CreatedAtAction(nameof(GetRecipeItem), new { id = recipeItem.ID }, recipeItem);
        }

        // DELETE: api/RecipeItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RecipeItem>> DeleteRecipeItem(int id)
        {
            var recipeItem = await _context.RecipeItems.FindAsync(id);
            if (recipeItem == null)
            {
                return NotFound();
            }

            _context.RecipeItems.Remove(recipeItem);
            await _context.SaveChangesAsync();

            return recipeItem;
        }

        private bool RecipeItemExists(int id)
        {
            return _context.RecipeItems.Any(e => e.ID == id);
        }
    }
}
