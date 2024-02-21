using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Events_Manager_14905.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventNames", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "EventRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    EventNamesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventRatings_EventNames_EventNamesId",
                        column: x => x.EventNamesId,
                        principalTable: "EventNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventRatings_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventRatings_EventId",
                table: "EventRatings",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRatings_EventNamesId",
                table: "EventRatings",
                column: "EventNamesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventRatings");

            migrationBuilder.DropTable(
                name: "EventNames");

            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
