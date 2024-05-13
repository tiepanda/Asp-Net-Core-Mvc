﻿// <auto-generated />
using Bulky.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bulky.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "food"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "motorsports"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "art"
                        });
                });

            modelBuilder.Entity("Bulky.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TicketPrice")
                        .HasColumnType("float");

                    b.Property<string>("TicketTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "a game relese Event .... .... .",
                            ISBN = "123123123",
                            Location = "Bengaluru, KA, IN",
                            Publisher = "Riot",
                            TicketPrice = 99.0,
                            TicketTitle = "Fortune of Time"
                        },
                        new
                        {
                            Id = 2,
                            Description = "it's a drag race event  where modified, 2/4wheel builts and stock vehicles and showcase and much more.... .... .",
                            ISBN = "231231231",
                            Location = "Pune, MH, IN",
                            Publisher = "Elite Octane",
                            TicketPrice = 800.0,
                            TicketTitle = "The Valley Run"
                        },
                        new
                        {
                            Id = 3,
                            Description = "it's a event for Gamer  and costume computer build where people  can show there skill in gaming and build unique computer.... .... .",
                            ISBN = "312312312",
                            Location = "Whitefield, KA, IN",
                            Publisher = "Intel",
                            TicketPrice = 0.0,
                            TicketTitle = "Intel Gamers day"
                        },
                        new
                        {
                            Id = 4,
                            Description = "badminton tournament organised by Sai academy.... .... .",
                            ISBN = "142323423",
                            Location = "Mysore, KA, IN",
                            Publisher = "Sai academy",
                            TicketPrice = 199.0,
                            TicketTitle = "badminton heist"
                        },
                        new
                        {
                            Id = 5,
                            Description = "a game relese Event .... .... .",
                            ISBN = "132132132",
                            Location = "Bengaluru, KA, IN",
                            Publisher = "Riot",
                            TicketPrice = 29.0,
                            TicketTitle = "Fortune of Time"
                        },
                        new
                        {
                            Id = 6,
                            Description = "it's a drag race event  where modified, 2/4wheel builts and stock vehicles and showcase and much more.... .... .",
                            ISBN = "213213213",
                            Location = "Pune, MH, IN",
                            Publisher = "Elite Octane",
                            TicketPrice = 800.0,
                            TicketTitle = "The Valley Run"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
