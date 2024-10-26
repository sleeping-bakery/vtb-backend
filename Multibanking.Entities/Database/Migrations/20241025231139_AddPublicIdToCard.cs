using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Multibanking.Entities.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddPublicIdToCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                table: "Cards",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "Cards");
        }
    }
}
