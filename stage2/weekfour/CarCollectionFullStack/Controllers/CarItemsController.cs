using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarCollectionFullStack.Models;

namespace CarCollectionFullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarItemsController : ControllerBase
    {
        private readonly CarCollectionContext _context;

        public CarItemsController(CarCollectionContext context)
        {
            _context = context;
        }

        // GET: api/CarItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarItem>>> GetTodoItems()
        {
            return await _context.TodoItems.ToListAsync();
        }

        // GET: api/CarItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarItem>> GetCarItem(long id)
        {
            var carItem = await _context.TodoItems.FindAsync(id);

            if (carItem == null)
            {
                return NotFound();
            }

            return carItem;
        }

        // PUT: api/CarItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarItem(long id, CarItem carItem)
        {
            if (id != carItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(carItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarItemExists(id))
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

        // POST: api/CarItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarItem>> PostCarItem(CarItem carItem)
        {
            _context.TodoItems.Add(carItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarItem", new { id = carItem.Id }, carItem);
        }

        // DELETE: api/CarItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarItem(long id)
        {
            var carItem = await _context.TodoItems.FindAsync(id);
            if (carItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(carItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarItemExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
