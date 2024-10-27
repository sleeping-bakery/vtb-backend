#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Multibanking.Entities.Database.Migrations;

/// <inheritdoc />
public partial class AddCardEntity : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            "Cards",
            table => new
            {
                Id = table.Column<Guid>("uuid", nullable: false),
                AccountId = table.Column<string>("text", nullable: false),
                UserId = table.Column<Guid>("uuid", nullable: false),
                Pan = table.Column<string>("text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Cards", x => x.Id);
                table.ForeignKey(
                    "FK_Cards_User_UserId",
                    x => x.UserId,
                    "User",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            "IX_Cards_UserId",
            "Cards",
            "UserId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            "Cards");
    }
}