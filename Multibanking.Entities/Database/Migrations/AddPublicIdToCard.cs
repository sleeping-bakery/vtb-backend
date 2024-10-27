#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Multibanking.Entities.Database.Migrations;

/// <inheritdoc />
public partial class AddPublicIdToCard : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            "PublicId",
            "Cards",
            "text",
            nullable: false,
            defaultValue: "");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            "PublicId",
            "Cards");
    }
}