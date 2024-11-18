using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManager.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1092), new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1106), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1108), new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1109), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Syntax", new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1350), new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1351), "BMW", "Syntax" },
                    { 2, "Syntax", new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1353), new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1354), "Toyota", "Syntax" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Syntax", new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1442), new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1443), "i4", "Syntax" },
                    { 2, "Syntax", new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1445), new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1445), "X5", "Syntax" },
                    { 3, "Syntax", new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1447), new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1447), "Prius", "Syntax" },
                    { 4, "Syntax", new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1449), new DateTime(2024, 11, 18, 16, 57, 51, 475, DateTimeKind.Local).AddTicks(1449), "C-HR", "Syntax" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
