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
    public class DutyTypeController : ControllerBase
    {
        private readonly FlatmateDBContext _context;

        public DutyTypeController(FlatmateDBContext context)
        {
            _context = context;
        }

        // GET: api/DutyType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DutyType>>> GetDutyTypes()
        {
            return await _context.DutyTypes.ToListAsync();
        }

        // GET: api/DutyType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DutyType>> GetDutyType(int id)
        {
            var dutyType = await _context.DutyTypes.FindAsync(id);

            if (dutyType == null)
            {
                return NotFound();
            }

            return dutyType;
        }

        // PUT: api/DutyType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDutyType(int id, DutyType dutyType)
        {
            if (id != dutyType.Id)
            {
                return BadRequest();
            }

            _context.Entry(dutyType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DutyTypeExists(id))
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

        // POST: api/DutyType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DutyType>> PostDutyType(DutyType dutyType)
        {
            _context.DutyTypes.Add(dutyType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDutyType", new { id = dutyType.Id }, dutyType);
        }

        // DELETE: api/DutyType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDutyType(int id)
        {
            var dutyType = await _context.DutyTypes.FindAsync(id);
            if (dutyType == null)
            {
                return NotFound();
            }

            _context.DutyTypes.Remove(dutyType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DutyTypeExists(int id)
        {
            return _context.DutyTypes.Any(e => e.Id == id);
        }
    }
}
