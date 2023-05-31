using Microsoft.EntityFrameworkCore;
using P231Relations.Entities;

namespace P231Relations.DAL
{
    public class RelationsDbContext:DbContext
    {
        public RelationsDbContext(DbContextOptions<RelationsDbContext> options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
