using Microsoft.EntityFrameworkCore.Migrations;

namespace ckl.Migrations
{
    public partial class in2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoroscropeReadings_UploadedFiles_Id",
                table: "HoroscropeReadings");

            migrationBuilder.DropForeignKey(
                name: "FK_Newsletters_UploadedFiles_Id",
                table: "Newsletters");

            migrationBuilder.DropForeignKey(
                name: "FK_SaturnReports_UploadedFiles_Id",
                table: "SaturnReports");

            migrationBuilder.DropIndex(
                name: "IX_SaturnReports_Id",
                table: "SaturnReports");

            migrationBuilder.DropIndex(
                name: "IX_Newsletters_Id",
                table: "Newsletters");

            migrationBuilder.DropIndex(
                name: "IX_HoroscropeReadings_Id",
                table: "HoroscropeReadings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SaturnReports_Id",
                table: "SaturnReports",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Newsletters_Id",
                table: "Newsletters",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoroscropeReadings_Id",
                table: "HoroscropeReadings",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HoroscropeReadings_UploadedFiles_Id",
                table: "HoroscropeReadings",
                column: "Id",
                principalTable: "UploadedFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Newsletters_UploadedFiles_Id",
                table: "Newsletters",
                column: "Id",
                principalTable: "UploadedFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaturnReports_UploadedFiles_Id",
                table: "SaturnReports",
                column: "Id",
                principalTable: "UploadedFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
