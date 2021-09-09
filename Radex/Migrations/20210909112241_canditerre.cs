using Microsoft.EntityFrameworkCore.Migrations;

namespace Radex.Migrations
{
    public partial class canditerre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Recruiters_RecruiterId",
                table: "Candidates");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Recruiters_RecruiterId",
                table: "Candidates",
                column: "RecruiterId",
                principalTable: "Recruiters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Recruiters_RecruiterId",
                table: "Candidates");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Recruiters_RecruiterId",
                table: "Candidates",
                column: "RecruiterId",
                principalTable: "Recruiters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
