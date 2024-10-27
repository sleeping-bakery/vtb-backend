using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Multibanking.PeriodPaymentClient.Model;

#nullable disable

namespace Multibanking.Entities.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddPeriodPaymentConsent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PeriodPaymentConsents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CardId = table.Column<Guid>(type: "uuid", nullable: false),
                    ConsentBanking = table.Column<VRPConsentResponse>(type: "jsonb", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodPaymentConsents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeriodPaymentConsents_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeriodPaymentConsents_CardId",
                table: "PeriodPaymentConsents",
                column: "CardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeriodPaymentConsents");
        }
    }
}
