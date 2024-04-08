using Microsoft.EntityFrameworkCore;
using AniAvagyan.Models.Entities;

namespace AniAvagyan.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {    
        }
        public DbSet<Student> Students { get; set; }
    }
}
