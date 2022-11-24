using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseService.Data.Migrations
{
    /// <inheritdoc />
    public partial class bugfix1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_ItemId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_ItemId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Item");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemId",
                table: "Item",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_ItemId",
                table: "Item",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id");
        }
    }
}
