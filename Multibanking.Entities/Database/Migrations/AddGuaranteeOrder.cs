#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.Entities.Database.Migrations;

/// <inheritdoc />
public partial class AddGuaranteeOrder : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            "GuaranteeOrders",
            table => new
            {
                Id = table.Column<Guid>("uuid", nullable: false),
                UserId = table.Column<Guid>("uuid", nullable: false),
                ResponseInit = table.Column<OrderResponse>("jsonb", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_GuaranteeOrders", x => x.Id); });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            "GuaranteeOrders");
    }
}