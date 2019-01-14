using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ckl.Migrations
{
    public partial class text : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribed",
                schema: "dbo",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "BaseCost",
                table: "SaturnReports",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribed",
                table: "SaturnReports",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "SaturnReports",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BaseCost",
                table: "Newsletters",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribed",
                table: "Newsletters",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Newsletters",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BaseCost",
                table: "HoroscropeReadings",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribed",
                table: "HoroscropeReadings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "HoroscropeReadings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Context",
                table: "Emails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "htmlMessage",
                table: "Emails",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TextMsg",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    To = table.Column<int>(nullable: false),
                    From = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextMsg", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TextMsg");

            migrationBuilder.DropColumn(
                name: "IsSubscribed",
                schema: "dbo",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BaseCost",
                table: "SaturnReports");

            migrationBuilder.DropColumn(
                name: "IsSubscribed",
                table: "SaturnReports");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "SaturnReports");

            migrationBuilder.DropColumn(
                name: "BaseCost",
                table: "Newsletters");

            migrationBuilder.DropColumn(
                name: "IsSubscribed",
                table: "Newsletters");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Newsletters");

            migrationBuilder.DropColumn(
                name: "BaseCost",
                table: "HoroscropeReadings");

            migrationBuilder.DropColumn(
                name: "IsSubscribed",
                table: "HoroscropeReadings");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "HoroscropeReadings");

            migrationBuilder.DropColumn(
                name: "Context",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "htmlMessage",
                table: "Emails");
        }
    }
}
