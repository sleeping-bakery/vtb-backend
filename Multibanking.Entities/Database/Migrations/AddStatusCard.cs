#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Multibanking.Entities.Database.Migrations;

/// <inheritdoc />
public partial class AddStatusCard : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<int>(
            "Status",
            "Cards",
            "integer",
            nullable: false,
            defaultValue: 0);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            "Status",
            "Cards");
    }
}