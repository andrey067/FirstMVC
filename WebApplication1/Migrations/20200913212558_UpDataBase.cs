using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class UpDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaSalesRecord_Seller_SellerId",
                table: "SaSalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaSalesRecord",
                table: "SaSalesRecord");

            migrationBuilder.RenameTable(
                name: "SaSalesRecord",
                newName: "SalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SaSalesRecord_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "SaSalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SaSalesRecord",
                newName: "IX_SaSalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaSalesRecord",
                table: "SaSalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaSalesRecord_Seller_SellerId",
                table: "SaSalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
