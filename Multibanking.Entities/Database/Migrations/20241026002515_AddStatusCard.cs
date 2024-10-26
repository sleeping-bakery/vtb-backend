using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Multibanking.Entities.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Cards",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Cards");
        }
    }
}
