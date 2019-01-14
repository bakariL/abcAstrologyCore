using Microsoft.EntityFrameworkCore.Migrations;

namespace ckl.Migrations
{
    public partial class i : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "Request",
                newName: "Email");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Request",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Request",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Request",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Request",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Request",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Request_UserId",
                table: "Request",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_tblUsers_UserId",
                table: "Request",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "tblUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_tblUsers_UserId",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Request_UserId",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Request");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Request",
                newName: "email");
        }
    }
}
