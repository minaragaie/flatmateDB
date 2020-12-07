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
    public class UserInvitationController : ControllerBase
    {
        private readonly FlatmateDBContext _context;

        public UserInvitationController(FlatmateDBContext context)
        {
            _context = context;
        }

        // GET: api/UserInvitation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserInvitation>>> GetUserInvitation()
        {
            return await _context.UserInvitation.ToListAsync();
        }

        // GET: api/UserInvitation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserInvitation>> GetUserInvitation(int id)
        {
            var userInvitation = await _context.UserInvitation.FindAsync(id);

            if (userInvitation == null)
            {
                return NotFound();
            }

            return userInvitation;
        }

        // PUT: api/UserInvitation/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserInvitation(int id, UserInvitation userInvitation)
        {
            if (id != userInvitation.Id)
            {
                return BadRequest();
            }

            _context.Entry(userInvitation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserInvitationExists(id))
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

        // POST: api/UserInvitation
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserInvitation>> PostUserInvitation(UserInvitation userInvitation)
        {
            _context.UserInvitation.Add(userInvitation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserInvitation", new { id = userInvitation.Id }, userInvitation);
        }

        // DELETE: api/UserInvitation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserInvitation(int id)
        {
            var userInvitation = await _context.UserInvitation.FindAsync(id);
            if (userInvitation == null)
            {
                return NotFound();
            }

            _context.UserInvitation.Remove(userInvitation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserInvitationExists(int id)
        {
            return _context.UserInvitation.Any(e => e.Id == id);
        }
    }
}
