using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpDesk.Api.Migrations
{
    public partial class seedDataConfigurationSkillCodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ref_Skill_Codes",
                columns: new[] { "SkillCode", "Description" },
                values: new object[] { 1, "Hardware Repair" });

            migrationBuilder.InsertData(
                table: "Ref_Skill_Codes",
                columns: new[] { "SkillCode", "Description" },
                values: new object[] { 2, "Database Dev" });

            migrationBuilder.InsertData(
                table: "Ref_Skill_Codes",
                columns: new[] { "SkillCode", "Description" },
                values: new object[] { 3, "Backend Dev" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ref_Skill_Codes",
                keyColumn: "SkillCode",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ref_Skill_Codes",
                keyColumn: "SkillCode",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ref_Skill_Codes",
                keyColumn: "SkillCode",
                keyValue: 3);
        }
    }
}
