using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaRestFulAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This villa is available for now", "https://images.unsplash.com/photo-1586106195724-b1a1e3857559?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Royal Villa", 5, 200.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Private Beach", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sea facing beauty", "https://example.com/oceanvilla.jpg", "Ocean Villa", 4, 250.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Trekking", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mountain view", "https://example.com/mountainvilla.jpg", "Mountain Villa", 6, 180.0, 620, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Spa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City center location", "https://example.com/urbanvilla.jpg", "Urban Villa", 4, 220.0, 480, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Camel rides", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Located in the serene desert", "https://example.com/desertvilla.jpg", "Desert Villa", 3, 210.0, 460, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
