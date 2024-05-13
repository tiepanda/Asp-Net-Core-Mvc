using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketPrice = table.Column<double>(type: "float", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ISBN", "Location", "Publisher", "TicketPrice", "TicketTitle" },
                values: new object[,]
                {
                    { 1, "a game relese Event .... .... .", "123123123", "Bengaluru, KA, IN", "Riot", 99.0, "Fortune of Time" },
                    { 2, "it's a drag race event  where modified, 2/4wheel builts and stock vehicles and showcase and much more.... .... .", "231231231", "Pune, MH, IN", "Elite Octane", 800.0, "The Valley Run" },
                    { 3, "it's a event for Gamer  and costume computer build where people  can show there skill in gaming and build unique computer.... .... .", "312312312", "Whitefield, KA, IN", "Intel", 0.0, "Intel Gamers day" },
                    { 4, "badminton tournament organised by Sai academy.... .... .", "142323423", "Mysore, KA, IN", "Sai academy", 199.0, "badminton heist" },
                    { 5, "a game relese Event .... .... .", "132132132", "Bengaluru, KA, IN", "Riot", 29.0, "Fortune of Time" },
                    { 6, "it's a drag race event  where modified, 2/4wheel builts and stock vehicles and showcase and much more.... .... .", "213213213", "Pune, MH, IN", "Elite Octane", 800.0, "The Valley Run" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
