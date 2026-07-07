using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EshopAPI.Migrations
{
    /// <inheritdoc />
    public partial class RenameDbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_prodacts_ProductId",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comments",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_prodacts",
                table: "prodacts");

            migrationBuilder.RenameTable(
                name: "comments",
                newName: "Comments");

            migrationBuilder.RenameTable(
                name: "prodacts",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_comments_ProductId",
                table: "Comments",
                newName: "IX_Comments_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Products_ProductId",
                table: "Comments",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Products_ProductId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "comments");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "prodacts");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ProductId",
                table: "comments",
                newName: "IX_comments_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_comments",
                table: "comments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_prodacts",
                table: "prodacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_prodacts_ProductId",
                table: "comments",
                column: "ProductId",
                principalTable: "prodacts",
                principalColumn: "Id");
        }
    }
}
