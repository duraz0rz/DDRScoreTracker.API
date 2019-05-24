using DDRScoreTracker.API.Models.Songs;
using Microsoft.EntityFrameworkCore;

namespace DDRScoreTracker.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public virtual DbSet<Song> Songs { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
    }
}
