using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShop.Api.Migrations.Products
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "products");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "products",
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("3609548c-7185-4c8e-b6c3-ca98e326d60f"), "Product #4", 400m },
                    { new Guid("3bd20657-9c3a-4d00-85f3-b1898dff6701"), "Product #3", 300m },
                    { new Guid("ea9930e6-d13c-40c2-aa42-587c15ec2146"), "Product #2", 200m },
                    { new Guid("f2623d69-0335-4857-bee2-f6ac33f81fff"), "Product #1", 100m },
                    { new Guid("f825d544-feda-4d44-97d4-9c8db3423a3b"), "Product #5", 500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "products");
        }
    }
}
