using DatingApp.Data;
using DatingApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController(DataContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await context.Users.ToListAsync();

            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await context.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }
    }
}
