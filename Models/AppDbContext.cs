
using Microsoft.EntityFrameworkCore;

namespace ApiNotePad.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        { }

        public DbSet<Note>? Note { get; set; }
    }
}