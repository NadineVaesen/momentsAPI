using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolMomentAPI.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moments_Teachers_TeacherId",
                table: "Moments");

            migrationBuilder.DropIndex(
                name: "IX_Moments_TeacherId",
                table: "Moments");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Moments");

            migrationBuilder.AlterColumn<string>(
                name: "StudentNumber",
                table: "Students",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "Moments",
                columns: new[] { "MomentId", "Category", "DateTime", "Duration", "Name" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2021, 11, 29, 11, 46, 53, 241, DateTimeKind.Local).AddTicks(8675), 2, "Moment0" },
                    { 2, 0, new DateTime(2021, 11, 23, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(4670), 2, "Moment1" },
                    { 3, 0, new DateTime(2021, 11, 23, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(4926), 2, "Moment2" },
                    { 4, 1, new DateTime(2021, 11, 27, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(4968), 2, "Moment3" },
                    { 5, 1, new DateTime(2021, 11, 22, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5000), 2, "Moment4" },
                    { 6, 3, new DateTime(2021, 11, 23, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5043), 2, "Moment5" },
                    { 7, 2, new DateTime(2021, 11, 29, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5085), 2, "Moment6" },
                    { 8, 2, new DateTime(2021, 11, 29, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5119), 2, "Moment7" },
                    { 9, 2, new DateTime(2021, 11, 23, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5151), 2, "Moment8" },
                    { 10, 0, new DateTime(2021, 11, 29, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5183), 2, "Moment9" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "MomentId", "MomentId1", "StudentNumber" },
                values: new object[,]
                {
                    { 10, "Student9", "LastName", null, null, "10000010" },
                    { 9, "Student8", "LastName", null, null, "10000009" },
                    { 8, "Student7", "LastName", null, null, "10000008" },
                    { 7, "Student6", "LastName", null, null, "10000007" },
                    { 6, "Student5", "LastName", null, null, "10000006" },
                    { 5, "Student4", "LastName", null, null, "10000005" },
                    { 4, "Student3", "LastName", null, null, "10000004" },
                    { 3, "Student2", "LastName", null, null, "10000003" },
                    { 2, "Student1", "LastName", null, null, "10000002" },
                    { 1, "Student0", "LastName", null, null, "10000001" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "FirstName", "LastName", "TeacherNumber" },
                values: new object[,]
                {
                    { 1, "Teacher0", "LastName", "1000000001" },
                    { 2, "Teacher1", "LastName", "1000000002" },
                    { 3, "Teacher2", "LastName", "1000000003" },
                    { 4, "Teacher3", "LastName", "1000000004" },
                    { 5, "Teacher4", "LastName", "1000000005" },
                    { 6, "Teacher5", "LastName", "1000000006" },
                    { 7, "Teacher6", "LastName", "1000000007" },
                    { 8, "Teacher7", "LastName", "1000000008" },
                    { 9, "Teacher8", "LastName", "1000000009" },
                    { 10, "Teacher9", "LastName", "1000000010" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "StudentNumber",
                table: "Students",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Moments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Moments_TeacherId",
                table: "Moments",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Moments_Teachers_TeacherId",
                table: "Moments",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
