using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ckl.Migrations
{
    public partial class _98 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BeginningDateofBirth",
                table: "SaturnReports",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DOB",
                table: "SaturnReports",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateofBirth",
                table: "SaturnReports",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndingDateofBirth",
                table: "SaturnReports",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserFirstName",
                table: "SaturnReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserGender",
                table: "SaturnReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserLastName",
                table: "SaturnReports",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeginningDateofBirth",
                table: "SaturnReports");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "SaturnReports");

            migrationBuilder.DropColumn(
                name: "DateofBirth",
                table: "SaturnReports");

            migrationBuilder.DropColumn(
                name: "EndingDateofBirth",
                table: "SaturnReports");

            migrationBuilder.DropColumn(
                name: "UserFirstName",
                table: "SaturnReports");

            migrationBuilder.DropColumn(
                name: "UserGender",
                table: "SaturnReports");

            migrationBuilder.DropColumn(
                name: "UserLastName",
                table: "SaturnReports");
        }
    }
}
