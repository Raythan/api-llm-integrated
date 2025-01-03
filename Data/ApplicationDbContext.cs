using Microsoft.EntityFrameworkCore;
using llm_integrated.Models;

namespace llm_integrated.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Opinion> Opinions { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
    }
}