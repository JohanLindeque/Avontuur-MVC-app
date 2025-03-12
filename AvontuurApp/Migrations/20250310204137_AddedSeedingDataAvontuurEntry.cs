using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AvontuurApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataAvontuurEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AvontuurEntries",
                columns: new[] { "Id", "Content", "CreatedAt", "Location", "Title" },
                values: new object[,]
                {
                    { 1, "1ste kamp met die nuwe 4x4 by 3 berge.", new DateTime(2025, 3, 10, 22, 41, 37, 262, DateTimeKind.Local).AddTicks(9863), "3 Berge kamp", "Eerste overland kamp" },
                    { 2, "1ste 4x4 trippie.", new DateTime(2025, 3, 10, 22, 41, 37, 262, DateTimeKind.Local).AddTicks(9865), "Pilansberg", "Eerste 4x4" },
                    { 3, "Caos, grade 4 trail", new DateTime(2025, 3, 10, 22, 41, 37, 262, DateTimeKind.Local).AddTicks(9867), "3 Berge", "Uitkyk" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AvontuurEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AvontuurEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AvontuurEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
