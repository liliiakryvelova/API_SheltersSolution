using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shelters.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShelterData",
                columns: table => new
                {
                    ShelterDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CatsNumber = table.Column<int>(type: "int", nullable: false),
                    DogsNumber = table.Column<int>(type: "int", nullable: false),
                    ShelterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShelterData", x => x.ShelterDataId);
                });

            migrationBuilder.CreateTable(
                name: "Shelters",
                columns: table => new
                {
                    ShelterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShelterName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelters", x => x.ShelterId);
                });

            migrationBuilder.InsertData(
                table: "ShelterData",
                columns: new[] { "ShelterDataId", "CatsNumber", "DogsNumber", "ShelterId" },
                values: new object[,]
                {
                    { 1, 4, 3, 1 },
                    { 2, 5, 8, 2 },
                    { 3, 1, 7, 3 },
                    { 4, 17, 5, 4 },
                    { 5, 7, 3, 5 },
                    { 6, 6, 10, 6 }
                });

            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "ShelterId", "Date", "ShelterName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 10, 19, 37, 42, 317, DateTimeKind.Local).AddTicks(8856), "Hope" },
                    { 2, new DateTime(2022, 9, 10, 19, 37, 42, 317, DateTimeKind.Local).AddTicks(9419), "Life" },
                    { 3, new DateTime(2022, 9, 10, 19, 37, 42, 317, DateTimeKind.Local).AddTicks(9429), "Clean the room" },
                    { 4, new DateTime(2022, 9, 10, 19, 37, 42, 317, DateTimeKind.Local).AddTicks(9432), "Four paws" },
                    { 5, new DateTime(2022, 9, 10, 19, 37, 42, 317, DateTimeKind.Local).AddTicks(9434), "My friend" },
                    { 6, new DateTime(2022, 9, 10, 19, 37, 42, 317, DateTimeKind.Local).AddTicks(9436), "Last tear" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShelterData");

            migrationBuilder.DropTable(
                name: "Shelters");
        }
    }
}
