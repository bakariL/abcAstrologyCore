using Microsoft.EntityFrameworkCore.Migrations;

namespace ckl.Migrations
{
    public partial class morefeilds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerCount",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NewsletterSubscribersCount",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NewslettersCreated",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NewslettersSent",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReadingSent",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReadingsCount",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedaingsRequest",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaturnReportCount",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaturnReportsCount",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaturnReportsRequested",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaturnReportsSent",
                table: "Partners",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerCount",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "NewsletterSubscribersCount",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "NewslettersCreated",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "NewslettersSent",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "ReadingSent",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "ReadingsCount",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "RedaingsRequest",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "SaturnReportCount",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "SaturnReportsCount",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "SaturnReportsRequested",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "SaturnReportsSent",
                table: "Partners");
        }
    }
}
