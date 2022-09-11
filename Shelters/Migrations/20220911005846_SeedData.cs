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
                value: new DateTime(2022, 9, 10, 17, 58, 46, 162, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 9, 10, 17, 58, 46, 162, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 9, 10, 17, 58, 46, 162, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 9, 10, 17, 58, 46, 162, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 9, 10, 17, 58, 46, 162, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 9, 10, 17, 58, 46, 162, DateTimeKind.Local).AddTicks(9336));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 9, 10, 17, 58, 37, 647, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 9, 10, 17, 58, 37, 647, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 9, 10, 17, 58, 37, 647, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 9, 10, 17, 58, 37, 647, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 9, 10, 17, 58, 37, 647, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 9, 10, 17, 58, 37, 647, DateTimeKind.Local).AddTicks(2534));
        }
    }
}
