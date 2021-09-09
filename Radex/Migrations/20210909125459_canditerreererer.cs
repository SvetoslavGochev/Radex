using Microsoft.EntityFrameworkCore.Migrations;

namespace Radex.Migrations
{
    public partial class canditerreererer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skils_Candidates_CandidateId",
                table: "Skils");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skils",
                table: "Skils");

            migrationBuilder.RenameTable(
                name: "Skils",
                newName: "Skills");

            migrationBuilder.RenameIndex(
                name: "IX_Skils_CandidateId",
                table: "Skills",
                newName: "IX_Skills_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Candidates_CandidateId",
                table: "Skills",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Candidates_CandidateId",
                table: "Skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "Skils");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_CandidateId",
                table: "Skils",
                newName: "IX_Skils_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skils",
                table: "Skils",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skils_Candidates_CandidateId",
                table: "Skils",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
