using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EshopAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixCommentColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProdactId",
                table: "Comments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdactId",
                table: "Comments",
                type: "int",
                nullable: true);
        }
    }
}
