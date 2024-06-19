using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("56b71d61-d9c9-4350-8722-9cbf5c983e5a"), "Coca Cola", 2.10m },
                    { new Guid("6a33b04d-67d8-43a4-91e3-3f1bf73f5860"), "Meat", 4.15m },
                    { new Guid("747a5828-debe-4bfd-a407-bb6334edd647"), "Potato", 1.05m },
                    { new Guid("a1957ca6-66bf-47d6-9f6b-4e0f4a27e961"), "Onion", 0.50m },
                    { new Guid("b620a89d-e67e-45f1-a39f-005868409fa0"), "Rice", 1.00m },
                    { new Guid("c219cbf9-1518-486c-97f1-28c5cc472be4"), "Bread", 0.80m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
