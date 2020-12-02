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
    public class DutyController : ControllerBase
    {
        private readonly FlatmateDBContext _context;

        public DutyController(FlatmateDBContext context)
        {
            _context = context;
        }

        // GET: api/Duty
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Duty>>> GetDuties()
        {
            return await _context.Duties.ToListAsync();
        }

        // GET: api/Duty/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Duty>> GetDuty(int id)
        {
            var duty = await _context.Duties.FindAsync(id);

            if (duty == null)
            {
                return NotFound();
            }

            return duty;
        }

        // PUT: api/Duty/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDuty(int id, Duty duty)
        {
            if (id != duty.Id)
            {
                return BadRequest();
            }

            _context.Entry(duty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DutyExists(id))
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

        // POST: api/Duty
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Duty>> PostDuty(Duty duty)
        {
            _context.Duties.Add(duty);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDuty", new { id = duty.Id }, duty);
        }

        // DELETE: api/Duty/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDuty(int id)
        {
            var duty = await _context.Duties.FindAsync(id);
            if (duty == null)
            {
                return NotFound();
            }

            _context.Duties.Remove(duty);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DutyExists(int id)
        {
            return _context.Duties.Any(e => e.Id == id);
        }
    }
}
