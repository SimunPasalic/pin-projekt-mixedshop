using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MixedShop.Migrations
{
    /// <inheritdoc />
    public partial class nadg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "Price",
                value: 75.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "Price",
                value: 299.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "Price",
                value: 15.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "Price",
                value: 49.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "Price",
                value: 79.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "Price",
                value: 119.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "Price",
                value: 119.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 8,
                column: "Price",
                value: 14.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 9,
                column: "Price",
                value: 89.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 10,
                column: "Price",
                value: 34.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 11,
                column: "Price",
                value: 389.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "Price",
                value: 207.00m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "Price",
                value: 240.00m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "Price",
                value: 499.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "Price",
                value: 2199.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "Price",
                value: 119.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "Price",
                value: 349.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "Price",
                value: 599.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "Price",
                value: 899.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "Price",
                value: 799.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 8,
                column: "Price",
                value: 110.00m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 9,
                column: "Price",
                value: 649.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 10,
                column: "Price",
                value: 249.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 11,
                column: "Price",
                value: 2909.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "Price",
                value: 1559.99m);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "Price",
                value: 1799.99m);
        }
    }
}
