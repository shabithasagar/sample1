using Microsoft.EntityFrameworkCore;
using sampleTestApi.Model;

namespace sampleTestApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<authorsList> authorsLists { get; set; }
    }
}
