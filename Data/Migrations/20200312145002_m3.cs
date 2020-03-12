using Microsoft.EntityFrameworkCore.Migrations;

namespace sklad.Data.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_AspNetUsers_ApplicationUserId1",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_ApplicationUserId1",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Address",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Address_ApplicationUserId",
                table: "Address",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_AspNetUsers_ApplicationUserId",
                table: "Address",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_AspNetUsers_ApplicationUserId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_ApplicationUserId",
                table: "Address");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Address",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Address",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Address_ApplicationUserId1",
                table: "Address",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_AspNetUsers_ApplicationUserId1",
                table: "Address",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
