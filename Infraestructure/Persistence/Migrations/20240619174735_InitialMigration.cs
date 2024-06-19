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
                    { new Guid("0bf6b028-6cff-4271-bf94-37b5f3c3744f"), "Onion", 0.50m },
                    { new Guid("3fdff7e9-5ad5-415e-94bb-9f8bd5dabc10"), "Rice", 1.00m },
                    { new Guid("4493afc2-ce99-418a-a0c1-1d9656f27c05"), "Bread", 0.80m },
                    { new Guid("ab3b69ed-dca0-429b-932f-21954265990f"), "Potato", 1.05m },
                    { new Guid("cd3c1122-f460-4125-ae0a-53d4b09365b4"), "Meat", 4.15m },
                    { new Guid("ec78609d-51e3-44a6-9776-abf5f0e8802b"), "Coca Cola", 2.10m }
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
