using Microsoft.EntityFrameworkCore.Migrations;

namespace ckl.Migrations
{
    public partial class texts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "To",
                table: "Emails",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Emails",
                newName: "To");
        }
    }
}
