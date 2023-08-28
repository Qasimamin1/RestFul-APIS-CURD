using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillaRestFulAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 14, 9, 31, 724, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "", new DateTime(2023, 8, 22, 14, 9, 31, 724, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "", new DateTime(2023, 8, 22, 14, 9, 31, 724, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "", new DateTime(2023, 8, 22, 14, 9, 31, 724, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "", new DateTime(2023, 8, 22, 14, 9, 31, 724, DateTimeKind.Local).AddTicks(2577) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "Private Beach", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "Trekking", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "Spa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate" },
                values: new object[] { "Camel rides", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
