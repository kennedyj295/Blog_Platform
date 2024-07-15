using blog_api.Data;
using blog_api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace blog_api.Controllers
{
    public class UsersController : BaseController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Users/{id}
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
    }
}
