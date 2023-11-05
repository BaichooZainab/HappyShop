using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HappyShop.Migrations
{
    /// <inheritdoc />
    public partial class addcategorytodatabase : Migration
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 5, 18, 32, 7, 315, DateTimeKind.Local).AddTicks(1047), 1, "Home Interiors" },
                    { 2, new DateTime(2023, 11, 5, 18, 32, 7, 315, DateTimeKind.Local).AddTicks(1057), 2, "Clothes & wears" },
                    { 3, new DateTime(2023, 11, 5, 18, 32, 7, 315, DateTimeKind.Local).AddTicks(1058), 3, "Computer & tech" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
