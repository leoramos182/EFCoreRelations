using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreRelations.Migrations
{
    public partial class UserCharacterRelationUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Character");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Character",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
