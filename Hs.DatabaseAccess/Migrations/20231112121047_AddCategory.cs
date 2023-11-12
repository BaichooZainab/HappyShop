using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hs.DatabaseAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCategory : Migration
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
                    pname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pdesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    brandname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    { 1, new DateTime(2023, 11, 12, 16, 10, 47, 29, DateTimeKind.Local).AddTicks(6915), 1, "Home Interiors" },
                    { 2, new DateTime(2023, 11, 12, 16, 10, 47, 29, DateTimeKind.Local).AddTicks(6928), 2, "Clothes & wears" },
                    { 3, new DateTime(2023, 11, 12, 16, 10, 47, 29, DateTimeKind.Local).AddTicks(6931), 3, "Computer & tech" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDateTime", "Quantity", "brandname", "pdesc", "pname", "price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 12, 16, 10, 47, 29, DateTimeKind.Local).AddTicks(7259), 20, "Ibanez", "This Guiter is electric", "Guitar", 1250 },
                    { 2, new DateTime(2023, 11, 12, 16, 10, 47, 29, DateTimeKind.Local).AddTicks(7264), 13, "Fender", "This Guiter is from Fender", "Piano", 2550 },
                    { 3, new DateTime(2023, 11, 12, 16, 10, 47, 29, DateTimeKind.Local).AddTicks(7267), 4, "Gibson Brand, Inc", "This Guiter is from Gibson Brand, Inc", "Drum", 3450 }
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
