using Microsoft.EntityFrameworkCore.Migrations;

namespace ckl.Migrations
{
    public partial class addedFeildsToRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DobDate",
                table: "Request",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DobDay",
                table: "Request",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DobMonthnum",
                table: "Request",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DobYear",
                table: "Request",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DobDate",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "DobDay",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "DobMonthnum",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "DobYear",
                table: "Request");
        }
    }
}
