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
    public class ActivityTypeController : ControllerBase
    {
        private readonly FlatmateDBContext _context;

        public ActivityTypeController(FlatmateDBContext context)
        {
            _context = context;
        }

        // GET: api/ActivityType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityType>>> GetActivityTypes()
        {
            return await _context.ActivityTypes.ToListAsync();
        }

        // GET: api/ActivityType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityType>> GetActivityType(int id)
        {
            var activityType = await _context.ActivityTypes.FindAsync(id);

            if (activityType == null)
            {
                return NotFound();
            }

            return activityType;
        }

        // PUT: api/ActivityType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivityType(int id, ActivityType activityType)
        {
            if (id != activityType.Id)
            {
                return BadRequest();
            }

            _context.Entry(activityType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityTypeExists(id))
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

        // POST: api/ActivityType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ActivityType>> PostActivityType(ActivityType activityType)
        {
            _context.ActivityTypes.Add(activityType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActivityType", new { id = activityType.Id }, activityType);
        }

        // DELETE: api/ActivityType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivityType(int id)
        {
            var activityType = await _context.ActivityTypes.FindAsync(id);
            if (activityType == null)
            {
                return NotFound();
            }

            _context.ActivityTypes.Remove(activityType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActivityTypeExists(int id)
        {
            return _context.ActivityTypes.Any(e => e.Id == id);
        }
    }
}
