using Microsoft.EntityFrameworkCore.Migrations;

namespace ckl.Migrations
{
    public partial class takewacycsutDI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoroscropeReadings_Customers_CustomerId",
                table: "HoroscropeReadings");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "HoroscropeReadings",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_HoroscropeReadings_Customers_CustomerId",
                table: "HoroscropeReadings",
                column: "CustomerId",
                principalSchema: "dbo",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoroscropeReadings_Customers_CustomerId",
                table: "HoroscropeReadings");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "HoroscropeReadings",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HoroscropeReadings_Customers_CustomerId",
                table: "HoroscropeReadings",
                column: "CustomerId",
                principalSchema: "dbo",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
