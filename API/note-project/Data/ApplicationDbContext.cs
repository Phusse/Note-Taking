using Microsoft.EntityFrameworkCore;
using note_project.models;

namespace note_project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<notes> Notes { get; set; }
    }
}