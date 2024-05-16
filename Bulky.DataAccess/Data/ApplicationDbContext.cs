using Bulky.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "food", DisplayOrder = 1 },
                new Category { Id = 2, Name = "motorsports", DisplayOrder = 2 },
                new Category { Id = 3, Name = "art", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    TicketTitle = "Fortune of Time",
                    Publisher = "Riot" ,
                    Description = "a game relese Event .... .... .",
                    ISBN = "123123123",
                    TicketPrice = 99 ,
                    Location = "Bengaluru, KA, IN",
                    CategoryId = 3,
                    ImageUrl=""

                },

                new Product
                {
                    Id = 2,
                    TicketTitle = "The Valley Run",
                    Publisher = "Elite Octane",
                    Description = "it's a drag race event  where modified, " +
                    "2/4wheel builts and stock vehicles and showcase and much more.... .... .",
                    ISBN = "231231231",
                    TicketPrice = 800,
                    Location = "Pune, MH, IN",
                    CategoryId = 2,
                    ImageUrl = ""

                },

                new Product
                {
                    Id = 3,
                    TicketTitle = "Intel Gamers day",
                    Publisher = "Intel",
                    Description = "it's a event for Gamer  and costume computer " +
                    "build where people  can show there " +
                    "skill in gaming and build unique computer.... .... .",
                    ISBN = "312312312",
                    TicketPrice = 0,
                    Location = "Whitefield, KA, IN",
                    CategoryId = 3,
                    ImageUrl = ""

                },


                new Product
                {
                    Id = 4,
                    TicketTitle = "badminton heist",
                    Publisher = "Sai academy",
                    Description = "badminton tournament organised by Sai academy.... .... .",
                    ISBN = "142323423",
                    TicketPrice = 199,
                    Location = "Mysore, KA, IN",
                    CategoryId = 1,
                    ImageUrl = ""
                },

                new Product
                {
                    Id = 5,
                    TicketTitle = "Fortune of Time",
                    Publisher = "Riot",
                    Description = "a game relese Event .... .... .",
                    ISBN = "132132132",
                    TicketPrice = 29,
                    Location = "Bengaluru, KA, IN",
                    CategoryId = 3,
                    ImageUrl = ""

                },

                new Product
                {
                    Id = 6,
                    TicketTitle = "The Valley Run",
                    Publisher = "Elite Octane",
                    Description = "it's a drag race event  where modified, " +
                    "2/4wheel builts and stock vehicles and showcase and much more.... .... .",
                    ISBN = "213213213",
                    TicketPrice = 800,
                    Location = "Pune, MH, IN",
                    CategoryId = 2,
                    ImageUrl = ""

                }

                );

        }


    }

}
