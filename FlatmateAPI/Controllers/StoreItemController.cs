using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FlatmateAPI.Models;

namespace FlatmateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreItemController : ControllerBase
    {
        private readonly FlatmateDBContext _context;

        public StoreItemController(FlatmateDBContext context)
        {
            _context = context;
        }

        // GET: api/StoreItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoreItem>>> GetStoresItems()
        {
            return await _context.StoresItems.ToListAsync();
        }

        // GET: api/StoreItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoreItem>> GetStoreItem(int id)
        {
            var storeItem = await _context.StoresItems.FindAsync(id);

            if (storeItem == null)
            {
                return NotFound();
            }

            return storeItem;
        }

        // PUT: api/StoreItem/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoreItem(int id, StoreItem storeItem)
        {
            if (id != storeItem.ItemId)
            {
                return BadRequest();
            }

            _context.Entry(storeItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoreItemExists(id))
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

        // POST: api/StoreItem
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoreItem>> PostStoreItem(StoreItem storeItem)
        {
            _context.StoresItems.Add(storeItem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoreItemExists(storeItem.ItemId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoreItem", new { id = storeItem.ItemId }, storeItem);
        }

        // DELETE: api/StoreItem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoreItem(int id)
        {
            var storeItem = await _context.StoresItems.FindAsync(id);
            if (storeItem == null)
            {
                return NotFound();
            }

            _context.StoresItems.Remove(storeItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoreItemExists(int id)
        {
            return _context.StoresItems.Any(e => e.ItemId == id);
        }
    }
}
