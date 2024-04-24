using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "food", DisplayOrder = 1 },
                new Category { Id = 2, Name = "motorsports", DisplayOrder = 2 },
                new Category { Id = 3, Name = "art", DisplayOrder = 3 }
                );
        }


    }

}
