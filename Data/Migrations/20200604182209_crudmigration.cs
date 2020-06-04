using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTrackerv2.Data.Migrations
{
    public partial class crudmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BugForms",
                columns: table => new
                {
                    BugId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BugTitle = table.Column<string>(name: "Bug Title", nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    Assignee = table.Column<string>(nullable: false),
                    StepstoReproduce = table.Column<string>(nullable: false),
                    ApplicationUsage = table.Column<string>(nullable: true),
                    ExpectedResult = table.Column<string>(nullable: false),
                    ActualResult = table.Column<string>(nullable: false),
                    BugType = table.Column<string>(nullable: false),
                    BugPriority = table.Column<string>(nullable: false),
                    BugSeverity = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateInactive = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BugForms", x => x.BugId);
                });

            migrationBuilder.InsertData(
                table: "BugForms",
                columns: new[] { "BugId", "ActualResult", "ApplicationUsage", "Assignee", "BugPriority", "BugSeverity", "BugType", "DateCreated", "DateInactive", "ExpectedResult", "IsActive", "StepstoReproduce", "Summary", "Bug Title" },
                values: new object[] { 1, "It does not open up", "I did alot", "Stephen", "P1", "High", "Website", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It opens up!", true, "I did alot!", "Upon opening website loads very slowly", "Poor Website loading" });

            migrationBuilder.InsertData(
                table: "BugForms",
                columns: new[] { "BugId", "ActualResult", "ApplicationUsage", "Assignee", "BugPriority", "BugSeverity", "BugType", "DateCreated", "DateInactive", "ExpectedResult", "IsActive", "StepstoReproduce", "Summary", "Bug Title" },
                values: new object[] { 2, "It does not open up", "I did alot", "Stephen", "P1", "High", "Website", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It opens up!", true, "I did alot!", "Upon opening website loads very slowly", "Poor Website loading" });

            migrationBuilder.InsertData(
                table: "BugForms",
                columns: new[] { "BugId", "ActualResult", "ApplicationUsage", "Assignee", "BugPriority", "BugSeverity", "BugType", "DateCreated", "DateInactive", "ExpectedResult", "IsActive", "StepstoReproduce", "Summary", "Bug Title" },
                values: new object[] { 3, "It does not open up", "I did alot", "Stephen", "P1", "High", "Website", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It opens up!", true, "I did alot!", "Upon opening website loads very slowly", "Poor Website loading" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BugForms");
        }
    }
}
