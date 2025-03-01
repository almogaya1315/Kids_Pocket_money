using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kids_Pocket_money.Migrations
{
    /// <inheritdoc />
    public partial class ChildrenTableAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ChildPoints = table.Column<int>(type: "int", nullable: false),
                    AddedPoints = table.Column<int>(type: "int", nullable: false),
                    pocketMoneySum = table.Column<int>(type: "int", nullable: false),
                    ChildScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Children",
                columns: new[] { "Id", "AddedPoints", "Age", "ChildPoints", "ChildScore", "Name", "pocketMoneySum" },
                values: new object[,]
                {
                    { 1, 0, 15, 0, 0, "Yiska", 0 },
                    { 2, 0, 13, 0, 0, "Moriya", 0 },
                    { 3, 0, 11, 0, 0, "Ariel", 0 },
                    { 4, 0, 4, 0, 0, "Yoav", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Children");

            
        }
    }
}
