using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hs.DatabaseAccess.Migrations
{
    /// <inheritdoc />
    public partial class addroletodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 3, 17, 17, 31, 527, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 3, 17, 17, 31, 527, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 3, 17, 17, 31, 527, DateTimeKind.Local).AddTicks(1597));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 2, 21, 48, 37, 727, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 2, 21, 48, 37, 727, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 2, 21, 48, 37, 727, DateTimeKind.Local).AddTicks(5695));
        }
    }
}
