using Microsoft.EntityFrameworkCore.Migrations;

namespace OivaTaitoApp.Data.Migrations
{
    public partial class ModifiedAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppUsers_GoogleId",
                table: "AppUsers");

            migrationBuilder.AlterColumn<string>(
                name: "GoogleId",
                table: "AppUsers",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 21);

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_GoogleId",
                table: "AppUsers",
                column: "GoogleId",
                unique: true,
                filter: "[GoogleId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppUsers_GoogleId",
                table: "AppUsers");

            migrationBuilder.AlterColumn<int>(
                name: "GoogleId",
                table: "AppUsers",
                type: "int",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_GoogleId",
                table: "AppUsers",
                column: "GoogleId",
                unique: true);
        }
    }
}
