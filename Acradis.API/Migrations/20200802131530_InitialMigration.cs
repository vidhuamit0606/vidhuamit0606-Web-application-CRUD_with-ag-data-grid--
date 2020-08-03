using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Acradis.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    TotalCost = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Quantity", "Title", "TotalCost" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), 345.00m, 2, "Backplate replacement, ABS Plastic Louver, 3 - Section", null },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), 450.00m, 12, "Backplate replacement, ABS Plastic Louver, 4 - Section (FYA)", null },
                    { new Guid("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"), 500.00m, 8, "Backplate replacement, ABS Plastic Louver, 4 - Section (T-shaped protected only)", null },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), 20.00m, 48, "Backplate replacement, ABS Plastic Louver, 5 - Section", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
