using Microsoft.EntityFrameworkCore.Migrations;

namespace Radex.Migrations
{
    public partial class canditrecr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recruiters_Candidates_CandidateId",
                table: "Recruiters");

            migrationBuilder.DropIndex(
                name: "IX_Recruiters_CandidateId",
                table: "Recruiters");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "Recruiters");

            migrationBuilder.AddColumn<int>(
                name: "RecruiterId",
                table: "Candidates",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_RecruiterId",
                table: "Candidates",
                column: "RecruiterId");

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

            migrationBuilder.DropIndex(
                name: "IX_Candidates_RecruiterId",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "RecruiterId",
                table: "Candidates");

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "Recruiters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recruiters_CandidateId",
                table: "Recruiters",
                column: "CandidateId",
                unique: true,
                filter: "[CandidateId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Recruiters_Candidates_CandidateId",
                table: "Recruiters",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
