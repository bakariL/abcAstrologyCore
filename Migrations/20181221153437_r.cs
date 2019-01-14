using Microsoft.EntityFrameworkCore.Migrations;

namespace ckl.Migrations
{
    public partial class r : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SaturnReports",
                table: "SaturnReports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Newsletters",
                table: "Newsletters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoroscropeReadings",
                table: "HoroscropeReadings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaturnReports",
                table: "SaturnReports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Newsletters",
                table: "Newsletters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoroscropeReadings",
                table: "HoroscropeReadings",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SaturnReports",
                table: "SaturnReports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Newsletters",
                table: "Newsletters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoroscropeReadings",
                table: "HoroscropeReadings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaturnReports",
                table: "SaturnReports",
                columns: new[] { "Id", "SaturnReportId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Newsletters",
                table: "Newsletters",
                columns: new[] { "Id", "NewsletterId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoroscropeReadings",
                table: "HoroscropeReadings",
                columns: new[] { "Id", "HorosopeId" });
        }
    }
}
