using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeTaskReletion.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfessionId",
                table: "Chefs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Chefs_ProfessionId",
                table: "Chefs",
                column: "ProfessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chefs_Professions_ProfessionId",
                table: "Chefs",
                column: "ProfessionId",
                principalTable: "Professions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chefs_Professions_ProfessionId",
                table: "Chefs");

            migrationBuilder.DropIndex(
                name: "IX_Chefs_ProfessionId",
                table: "Chefs");

            migrationBuilder.DropColumn(
                name: "ProfessionId",
                table: "Chefs");
        }
    }
}
