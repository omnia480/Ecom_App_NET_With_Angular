using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecom.infrostructure.Data.Midrations;

/// <inheritdoc />
public partial class _20261123221317_seedData : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData(
            table: "Categories",
            columns: new[] { "Id", "Description", "Name" },
            values: new object[,]
            {
                { 1, "Electronic devices and gadgets", "Electronics" },
                { 2, "Apparel and fashion items", "Clothing" },
                { 3, "Books and literature", "Books" }
            });

        migrationBuilder.InsertData(
            table: "Products",
            columns: new[] { "Id", "Description", "Name", "Price", "categoryId" },
            values: new object[,]
            {
                { 1, "Latest smartphone with advanced features", "Smartphone", 699.99m, 1 },
                { 2, "High-performance laptop for work and gaming", "Laptop", 1299.99m, 1 },
                { 3, "Comfortable cotton t-shirt in various colors", "T-Shirt", 19.99m, 2 },
                { 4, "Stylish denim jeans for casual wear", "Jeans", 49.99m, 2 },
                { 5, "Bestselling fiction novel by a renowned author", "Novel", 14.99m, 3 },
                { 6, "Collection of delicious recipes for home cooking", "Cookbook", 24.99m, 3 }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "Products",
            keyColumn: "Id",
            keyValue: 1);

        migrationBuilder.DeleteData(
            table: "Products",
            keyColumn: "Id",
            keyValue: 2);

        migrationBuilder.DeleteData(
            table: "Products",
            keyColumn: "Id",
            keyValue: 3);

        migrationBuilder.DeleteData(
            table: "Products",
            keyColumn: "Id",
            keyValue: 4);

        migrationBuilder.DeleteData(
            table: "Products",
            keyColumn: "Id",
            keyValue: 5);

        migrationBuilder.DeleteData(
            table: "Products",
            keyColumn: "Id",
            keyValue: 6);

        migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "Id",
            keyValue: 1);

        migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "Id",
            keyValue: 2);

        migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "Id",
            keyValue: 3);
    }
}
