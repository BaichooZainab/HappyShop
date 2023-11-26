using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hs.DatabaseAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedToDatabase : Migration
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
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Productname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantities = table.Column<double>(type: "float", nullable: false),
                    Prices = table.Column<double>(type: "float", nullable: false),
                    Brandname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 26, 15, 5, 55, 934, DateTimeKind.Local).AddTicks(1408), 1, "Guitars" },
                    { 2, new DateTime(2023, 11, 26, 15, 5, 55, 934, DateTimeKind.Local).AddTicks(1417), 2, "Drums" },
                    { 3, new DateTime(2023, 11, 26, 15, 5, 55, 934, DateTimeKind.Local).AddTicks(1418), 3, "Piano" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brandname", "CategoryId", "Description", "Prices", "Productname", "Quantities" },
                values: new object[,]
                {
                    { 1, "Ibanez", 1, "This Guiter is electric", 1250.0, "Guitar", 20.0 },
                    { 2, "Fender", 3, "This piano is from Fender", 2550.0, "Piano", 13.0 },
                    { 3, "Gibson Brand, Inc", 2, "This Guiter is from Gibson Brand, Inc", 3450.0, "Drum", 4.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
