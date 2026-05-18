using Microsoft.EntityFrameworkCore;
using project01.Entities;

namespace project01.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MovieStreamingDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Watchlist>()
                .HasKey(w => new { w.UserId, w.MovieId });

            modelBuilder.Entity<Movie>()
                .HasQueryFilter(m => !m.IsDeleted);

            base.OnModelCreating(modelBuilder);
        }
    }
}