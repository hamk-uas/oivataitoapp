using Microsoft.EntityFrameworkCore.Migrations;

namespace OivaTaitoApp.Data.Migrations
{
    public partial class ModifedQuestionCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionSetId",
                table: "QuestionCategories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionSetId",
                table: "QuestionCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
