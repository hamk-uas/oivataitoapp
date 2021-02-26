using Microsoft.EntityFrameworkCore.Migrations;

namespace OivaTaitoApp.Data.Migrations
{
    public partial class ModifedQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Questions",
                maxLength: 250,
                nullable: false,
                defaultValue: ""
                );

            migrationBuilder.AddColumn<int>(
                name: "Identifier",
                table: "Questions",
                maxLength: 10,
                nullable: false
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Questions"
                );

            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "Questions"
                );
        }
    }
}
