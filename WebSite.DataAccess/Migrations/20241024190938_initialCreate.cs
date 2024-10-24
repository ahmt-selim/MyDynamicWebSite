using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSite.DataAccess.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyCompetences",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 225, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyCompetences", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MyEducationInfos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    schoolName = table.Column<string>(maxLength: 225, nullable: true),
                    schoolcity = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyEducationInfos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MyHobies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 225, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyHobies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MyInfos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 225, nullable: true),
                    surname = table.Column<string>(maxLength: 50, nullable: true),
                    city = table.Column<string>(maxLength: 50, nullable: true),
                    birthDay = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyInfos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyCompetences");

            migrationBuilder.DropTable(
                name: "MyEducationInfos");

            migrationBuilder.DropTable(
                name: "MyHobies");

            migrationBuilder.DropTable(
                name: "MyInfos");
        }
    }
}
