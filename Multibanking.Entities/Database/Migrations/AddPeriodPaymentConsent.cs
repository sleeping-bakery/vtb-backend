#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;
using Multibanking.PeriodPaymentClient.Model;

namespace Multibanking.Entities.Database.Migrations;

/// <inheritdoc />
public partial class AddPeriodPaymentConsent : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            "PeriodPaymentConsents",
            table => new
            {
                Id = table.Column<Guid>("uuid", nullable: false),
                CardId = table.Column<Guid>("uuid", nullable: false),
                ConsentBanking = table.Column<VRPConsentResponse>("jsonb", nullable: false),
                UserId = table.Column<Guid>("uuid", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PeriodPaymentConsents", x => x.Id);
                table.ForeignKey(
                    "FK_PeriodPaymentConsents_Cards_CardId",
                    x => x.CardId,
                    "Cards",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            "IX_PeriodPaymentConsents_CardId",
            "PeriodPaymentConsents",
            "CardId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            "PeriodPaymentConsents");
    }
}