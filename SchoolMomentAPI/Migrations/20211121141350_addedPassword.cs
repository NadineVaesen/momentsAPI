using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolMomentAPI.Migrations
{
    public partial class addedPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Students",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 1,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 1, new DateTime(2021, 11, 23, 15, 13, 48, 787, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 2,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 2, new DateTime(2021, 11, 22, 15, 13, 48, 790, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2021, 11, 27, 15, 13, 48, 790, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 4,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 0, new DateTime(2021, 11, 22, 15, 13, 48, 790, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 5,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 3, new DateTime(2021, 11, 29, 15, 13, 48, 790, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 6,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 1, new DateTime(2021, 11, 29, 15, 13, 48, 790, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 7,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 1, new DateTime(2021, 11, 29, 15, 13, 48, 790, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 8,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 0, new DateTime(2021, 11, 23, 15, 13, 48, 790, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 9,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 3, new DateTime(2021, 11, 25, 15, 13, 48, 790, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 10,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 3, new DateTime(2021, 11, 30, 15, 13, 48, 790, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "Password",
                value: "10000001@pxl");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "Password",
                value: "10000002@pxl");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "Password",
                value: "10000003@pxl");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "Password",
                value: "10000004@pxl");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5,
                column: "Password",
                value: "10000005@pxl");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6,
                column: "Password",
                value: "10000006@pxl");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7,
                column: "Password",
                value: "10000007@pxl");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8,
                column: "Password",
                value: "10000008@pxl");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9,
                column: "Password",
                value: "10000009@pxl");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10,
                column: "Password",
                value: "10000010@pxl");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1,
                column: "Password",
                value: "1000000001@pxl");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2,
                column: "Password",
                value: "1000000002@pxl");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3,
                column: "Password",
                value: "1000000003@pxl");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 4,
                column: "Password",
                value: "1000000004@pxl");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 5,
                column: "Password",
                value: "1000000005@pxl");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 6,
                column: "Password",
                value: "1000000006@pxl");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 7,
                column: "Password",
                value: "1000000007@pxl");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 8,
                column: "Password",
                value: "1000000008@pxl");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 9,
                column: "Password",
                value: "1000000009@pxl");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 10,
                column: "Password",
                value: "1000000010@pxl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 1,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 2, new DateTime(2021, 11, 29, 11, 46, 53, 241, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 2,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 0, new DateTime(2021, 11, 23, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2021, 11, 23, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 4,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 1, new DateTime(2021, 11, 27, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 5,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 1, new DateTime(2021, 11, 22, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 6,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 3, new DateTime(2021, 11, 23, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 7,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 2, new DateTime(2021, 11, 29, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 8,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 2, new DateTime(2021, 11, 29, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 9,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 2, new DateTime(2021, 11, 23, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Moments",
                keyColumn: "MomentId",
                keyValue: 10,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { 0, new DateTime(2021, 11, 29, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5183) });
        }
    }
}
