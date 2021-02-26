using Microsoft.EntityFrameworkCore.Migrations;

namespace OivaTaitoApp.Data.Migrations
{
    public partial class AddEvalImprovementContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImprovementVideoUrl",
                value: "https://www.youtube.com/watch?time_continue=1&v=V-kVfGk8Zqs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImprovementVideoUrl",
                value: null);
        }
    }
}
