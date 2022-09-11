using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shelters.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 37, 59, 625, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 37, 59, 625, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 37, 59, 625, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 37, 59, 625, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 37, 59, 625, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 37, 59, 625, DateTimeKind.Local).AddTicks(2862));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 37, 42, 317, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 37, 42, 317, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 37, 42, 317, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 37, 42, 317, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 37, 42, 317, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 37, 42, 317, DateTimeKind.Local).AddTicks(9436));
        }
    }
}
