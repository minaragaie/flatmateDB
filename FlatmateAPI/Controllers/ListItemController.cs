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
    public class ListItemController : ControllerBase
    {
        private readonly FlatmateDBContext _context;

        public ListItemController(FlatmateDBContext context)
        {
            _context = context;
        }

        // GET: api/ListItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListItem>>> GetListItems()
        {
            return await _context.ListItems.ToListAsync();
        }

        // GET: api/ListItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ListItem>> GetListItem(int? id)
        {
            var listItem = await _context.ListItems.FindAsync(id);

            if (listItem == null)
            {
                return NotFound();
            }

            return listItem;
        }

        // PUT: api/ListItem/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListItem(int? id, ListItem listItem)
        {
            if (id != listItem.ItemId)
            {
                return BadRequest();
            }

            _context.Entry(listItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListItemExists(id))
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

        // POST: api/ListItem
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ListItem>> PostListItem(ListItem listItem)
        {
            _context.ListItems.Add(listItem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ListItemExists(listItem.ItemId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetListItem", new { id = listItem.ItemId }, listItem);
        }

        // DELETE: api/ListItem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListItem(int? id)
        {
            var listItem = await _context.ListItems.FindAsync(id);
            if (listItem == null)
            {
                return NotFound();
            }

            _context.ListItems.Remove(listItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ListItemExists(int? id)
        {
            return _context.ListItems.Any(e => e.ItemId == id);
        }
    }
}
