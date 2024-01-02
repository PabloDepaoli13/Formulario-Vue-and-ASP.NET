using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Formulary.Migrations
{
    /// <inheritdoc />
    public partial class repairinitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_item_contract_ContractId",
                table: "item");

            migrationBuilder.DropForeignKey(
                name: "FK_item_item_ItemId",
                table: "item");

            migrationBuilder.DropIndex(
                name: "IX_item_ContractId",
                table: "item");

            migrationBuilder.DropIndex(
                name: "IX_item_ItemId",
                table: "item");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "item");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "item");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_item_ContractId",
                table: "item",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_item_ItemId",
                table: "item",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_item_contract_ContractId",
                table: "item",
                column: "ContractId",
                principalTable: "contract",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_item_item_ItemId",
                table: "item",
                column: "ItemId",
                principalTable: "item",
                principalColumn: "Id");
        }
    }
}
