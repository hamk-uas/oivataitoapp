using Microsoft.EntityFrameworkCore.Migrations;

namespace OivaTaitoApp.Data.Migrations
{
    public partial class ChangedResultColumnType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Answer",
                table: "SelfEvalResults",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Answer",
                table: "SelfEvalResults",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
