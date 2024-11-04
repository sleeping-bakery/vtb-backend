using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Multibanking.GuaranteeClient.Model;

#nullable disable

namespace Multibanking.Entities.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddGuaranteeOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuaranteeOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ResponseInit = table.Column<OrderResponse>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuaranteeOrders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuaranteeOrders");
        }
    }
}
