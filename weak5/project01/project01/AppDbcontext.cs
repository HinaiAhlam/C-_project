using System;
using Microsoft.EntityFrameworkCore;

namespace project01
{
    public class AppDbcontext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
                optionsBuilder.UseSqlServer("Server=.;Database=Project011DB;Trusted_Connection=True;TrustServerCertificate=True;");
            
        }


    }
}