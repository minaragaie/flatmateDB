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
    public class UserHouseController : ControllerBase
    {
        private readonly FlatmateDBContext _context;

        public UserHouseController(FlatmateDBContext context)
        {
            _context = context;
        }

        // GET: api/UserHouse
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserHouse>>> GetUsersHouses()
        {
            return await _context.UsersHouses.Include(i=>i.House).ToListAsync();
        }

        // GET: api/UserHouse/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserHouse>> GetUserHouse(int? id)
        {
            var userHouse = await _context.UsersHouses.Include(u => u.House).FirstOrDefaultAsync(i => i.Id == id);

            if (userHouse == null)
            {
                return NotFound();
            }

            return userHouse;
        }

        // PUT: api/UserHouse/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserHouse(int? id, UserHouse userHouse)
        {
            if (id != userHouse.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userHouse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserHouseExists(id))
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

        // POST: api/UserHouse
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserHouse>> PostUserHouse(UserHouse userHouse)
        {
            _context.UsersHouses.Add(userHouse);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserHouseExists(userHouse.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserHouse", new { id = userHouse.UserId }, userHouse);
        }

        // DELETE: api/UserHouse/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserHouse(int? id)
        {
            var userHouse = await _context.UsersHouses.FindAsync(id);
            if (userHouse == null)
            {
                return NotFound();
            }

            _context.UsersHouses.Remove(userHouse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserHouseExists(int? id)
        {
            return _context.UsersHouses.Any(e => e.UserId == id);
        }
    }
}
