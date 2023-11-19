using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hs.DatabaseAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Productname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantities = table.Column<double>(type: "float", nullable: false),
                    Prices = table.Column<double>(type: "float", nullable: false),
                    Brandname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 19, 22, 2, 29, 282, DateTimeKind.Local).AddTicks(1224), 1, "Home Interiors" },
                    { 2, new DateTime(2023, 11, 19, 22, 2, 29, 282, DateTimeKind.Local).AddTicks(1240), 2, "Clothes & wears" },
                    { 3, new DateTime(2023, 11, 19, 22, 2, 29, 282, DateTimeKind.Local).AddTicks(1242), 3, "Computer & tech" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brandname", "Description", "Prices", "Productname", "Quantities" },
                values: new object[,]
                {
                    { 1, "Ibanez", "This Guiter is electric", 1250.0, "Guitar", 20.0 },
                    { 2, "Fender", "This Guiter is from Fender", 2550.0, "Piano", 13.0 },
                    { 3, "Gibson Brand, Inc", "This Guiter is from Gibson Brand, Inc", 3450.0, "Drum", 4.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
