using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Formulary.Migrations
{
    /// <inheritdoc />
    public partial class updatename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_contract_ContractId",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_order_item_ItemId",
                table: "order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order",
                table: "order");

            migrationBuilder.RenameTable(
                name: "order",
                newName: "request");

            migrationBuilder.AddPrimaryKey(
                name: "PK_request",
                table: "request",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_request_contract_ContractId",
                table: "request",
                column: "ContractId",
                principalTable: "contract",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_request_item_ItemId",
                table: "request",
                column: "ItemId",
                principalTable: "item",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_request_contract_ContractId",
                table: "request");

            migrationBuilder.DropForeignKey(
                name: "FK_request_item_ItemId",
                table: "request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_request",
                table: "request");

            migrationBuilder.RenameTable(
                name: "request",
                newName: "order");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order",
                table: "order",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_contract_ContractId",
                table: "order",
                column: "ContractId",
                principalTable: "contract",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_item_ItemId",
                table: "order",
                column: "ItemId",
                principalTable: "item",
                principalColumn: "Id");
        }
    }
}
