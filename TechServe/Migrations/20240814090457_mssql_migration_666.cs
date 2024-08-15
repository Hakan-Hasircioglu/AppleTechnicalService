using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechServe.Migrations
{
    /// <inheritdoc />
    public partial class mssql_migration_666 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuySpareParts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparePartsBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SparePartsModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartsType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountOfSpareParts = table.Column<int>(type: "int", nullable: false),
                    Barcode = table.Column<int>(type: "int", nullable: false),
                    SparePrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuySpareParts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfService = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartsUsedForRepair = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SpareParts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparePartsBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SparePartsModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartsType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountOfSpareParts = table.Column<int>(type: "int", nullable: false),
                    Barcode = table.Column<int>(type: "int", nullable: false),
                    SparePrice = table.Column<int>(type: "int", nullable: false),
                    RepairOfCostOfThePart = table.Column<int>(type: "int", nullable: false),
                    ReplacementOfCostOfThePart = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpareParts", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuySpareParts");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "SpareParts");
        }
    }
}
