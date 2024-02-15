using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Events_Manager_14905.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EventDescription = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    EventCategory = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UserPhoneNum = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EventCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventFor = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
