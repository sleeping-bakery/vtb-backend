#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Multibanking.Entities.Database.Migrations;

/// <inheritdoc />
public partial class Initial : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            "User",
            table => new
            {
                Id = table.Column<Guid>("uuid", nullable: false),
                AccountConsents = table.Column<int[]>("integer[]", nullable: false),
                Login = table.Column<string>("text", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_User", x => x.Id); });

        migrationBuilder.CreateIndex(
            "IX_User_Login",
            "User",
            "Login",
            unique: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            "User");
    }
}