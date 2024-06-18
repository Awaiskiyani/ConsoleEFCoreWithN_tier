using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleEfCoreWithN_tier_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatatoBookAndPublisher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "Books",
                type: "decimal(10,5)",
                precision: 10,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Publisher_Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Peshawar", "Pub jimmy" },
                    { 2, "Peshawar", "Pub jimmy" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "ISBN", "Publisher_Id", "Title", "price" },
                values: new object[,]
                {
                    { 1, "7675", 1, "Spider", 10.99m },
                    { 2, "66784", 1, "Hollow", 16.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Publisher_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Publisher_Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,5)",
                oldPrecision: 10,
                oldScale: 5);
        }
    }
}
