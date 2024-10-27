#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Multibanking.Entities.Database.Migrations;

/// <inheritdoc />
public partial class AddUserAccountConsent : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            "UserAccountConsents",
            table => new
            {
                Id = table.Column<Guid>("uuid", nullable: false),
                UserId = table.Column<Guid>("uuid", nullable: false),
                AccountConsentId = table.Column<string>("text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_UserAccountConsents", x => x.Id);
                table.ForeignKey(
                    "FK_UserAccountConsents_User_UserId",
                    x => x.UserId,
                    "User",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            "IX_UserAccountConsents_UserId",
            "UserAccountConsents",
            "UserId",
            unique: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            "UserAccountConsents");
    }
}