using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sampleTestApi.Data;
using sampleTestApi.Model;

namespace sampleTestApi.Controllers
{
    public class sampleTestController : ControllerBase

    {
        private readonly ApplicationDbContext _context;
        public sampleTestController(ApplicationDbContext context)
        {
            _context = context;

        }

        //Get Authors List
        [HttpGet("Author")]
        public async Task<ActionResult<IEnumerable<authorsList>>> GetCompany()
        {
            return await _context.authorsLists.ToListAsync();
        }

        //Post Authors
        [HttpPost("registerAuthor")]
        public async Task<ActionResult<authorsList>> RegisterEmployee(authorsList emp)
        {
            if (_context.authorsLists.Any(u => u.Name == emp.Name))
            {
                return BadRequest("Username already exists.");
            }
            var user = new authorsList
            {
                Name = emp.Name,
                Bio = emp.Bio

            };
            _context.authorsLists.Add(user);
            _context.SaveChanges();
            return Ok("Successfully registerd new Author");
        }
    }
}
