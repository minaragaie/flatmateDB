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
    public class UserController : ControllerBase
    {
        private readonly FlatmateDBContext _context;

        public UserController(FlatmateDBContext context)
        {
            _context = context;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers( string email)
        {
            if (email is null)
            {//if email is null get all users 
                return await _context.Users
                .Include(u => u.Houses).ThenInclude(u => u.Posts).ThenInclude(u => u.Comments)
                .Include(u => u.Houses).ThenInclude(u => u.GroceryLists).ThenInclude(u => u.Items)
                .Include(u => u.Houses).ThenInclude(u => u.Duties)
                .ToListAsync();
            }
            else
            {//else get user by his email
                return await _context.Users.Where(i => i.Email.Equals(email))
                .Include(u => u.Houses).ThenInclude(u => u.Posts).ThenInclude(u => u.Comments)
                .Include(u => u.Houses).ThenInclude(u => u.GroceryLists).ThenInclude(u => u.Items)
                .Include(u => u.Houses).ThenInclude(u => u.Duties)
                .ToListAsync();
            }
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/User/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string uid)
        {
            var user = await _context.Users.FindAsync(uid);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
