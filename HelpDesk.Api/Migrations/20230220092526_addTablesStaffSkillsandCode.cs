using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpDesk.Api.Migrations
{
    public partial class addTablesStaffSkillsandCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ref_Skill_Codes",
                columns: table => new
                {
                    SkillCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Skill_Codes", x => x.SkillCode);
                });

            migrationBuilder.CreateTable(
                name: "Staff_Skills",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    SkillCode = table.Column<int>(type: "int", nullable: false),
                    SkillObtained = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff_Skills", x => new { x.StaffId, x.SkillCode });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ref_Skill_Codes");

            migrationBuilder.DropTable(
                name: "Staff_Skills");
        }
    }
}
