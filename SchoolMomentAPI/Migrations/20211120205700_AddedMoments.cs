using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolMomentAPI.Migrations
{
    public partial class AddedMoments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MomentId",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MomentId1",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Moments",
                columns: table => new
                {
                    MomentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moments", x => x.MomentId);
                    table.ForeignKey(
                        name: "FK_Moments_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_MomentId",
                table: "Students",
                column: "MomentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_MomentId1",
                table: "Students",
                column: "MomentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Moments_TeacherId",
                table: "Moments",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Moments_MomentId",
                table: "Students",
                column: "MomentId",
                principalTable: "Moments",
                principalColumn: "MomentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Moments_MomentId1",
                table: "Students",
                column: "MomentId1",
                principalTable: "Moments",
                principalColumn: "MomentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Moments_MomentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Moments_MomentId1",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Moments");

            migrationBuilder.DropIndex(
                name: "IX_Students_MomentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_MomentId1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MomentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MomentId1",
                table: "Students");
        }
    }
}
