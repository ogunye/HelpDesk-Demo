using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpDesk.Api.Migrations
{
    public partial class updateDBwithSupportStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupportStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_joined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_left = table.Column<DateTime>(type: "datetime2", nullable: false),
                    staff_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportStaff", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupportStaff");
        }
    }
}
