using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSite.DataAccess.Migrations
{
    public partial class AddColumsMyInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "about",
                table: "MyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "MyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telnumber",
                table: "MyInfos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "about",
                table: "MyInfos");

            migrationBuilder.DropColumn(
                name: "email",
                table: "MyInfos");

            migrationBuilder.DropColumn(
                name: "telnumber",
                table: "MyInfos");
        }
    }
}
