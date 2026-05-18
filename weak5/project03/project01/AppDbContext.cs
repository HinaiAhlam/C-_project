using Microsoft.EntityFrameworkCore;

namespace StudentManagementSystem
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!; 
        public DbSet<Department> Departments { get; set; } = null!; 
        public DbSet<Course> Courses { get; set; } = null!; 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Database=StudentManagementDb;Trusted_Connection=True;TrustServerCertificate=True;";

            optionsBuilder
                .UseLazyLoadingProxies() 
                .UseSqlServer(connectionString); 
        }
    }
}