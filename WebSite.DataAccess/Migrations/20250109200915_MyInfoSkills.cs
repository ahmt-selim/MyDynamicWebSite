using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSite.DataAccess.Migrations
{
    public partial class MyInfoSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "telnumber",
                table: "MyInfos");

            migrationBuilder.AddColumn<string>(
                name: "telephone",
                table: "MyInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyInfoId",
                table: "MyEducationInfos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MyInfoSkills",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyInfoId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyInfoSkills", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyInfoSkills");

            migrationBuilder.DropColumn(
                name: "telephone",
                table: "MyInfos");

            migrationBuilder.DropColumn(
                name: "MyInfoId",
                table: "MyEducationInfos");

            migrationBuilder.AddColumn<string>(
                name: "telnumber",
                table: "MyInfos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
