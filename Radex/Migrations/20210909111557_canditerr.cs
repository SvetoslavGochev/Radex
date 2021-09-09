using Microsoft.EntityFrameworkCore.Migrations;

namespace Radex.Migrations
{
    public partial class canditerr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Recruiters_RecruiterId",
                table: "Candidates");

            migrationBuilder.AlterColumn<int>(
                name: "RecruiterId",
                table: "Candidates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Recruiters_RecruiterId",
                table: "Candidates",
                column: "RecruiterId",
                principalTable: "Recruiters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Recruiters_RecruiterId",
                table: "Candidates");

            migrationBuilder.AlterColumn<int>(
                name: "RecruiterId",
                table: "Candidates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Recruiters_RecruiterId",
                table: "Candidates",
                column: "RecruiterId",
                principalTable: "Recruiters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
