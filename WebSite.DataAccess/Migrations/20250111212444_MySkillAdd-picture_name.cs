using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSite.DataAccess.Migrations
{
    public partial class MySkillAddpicture_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "picture_name",
                table: "MySkills",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "picture_name",
                table: "MySkills");
        }
    }
}
