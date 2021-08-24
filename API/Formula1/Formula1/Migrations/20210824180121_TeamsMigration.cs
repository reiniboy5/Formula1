using Microsoft.EntityFrameworkCore.Migrations;

namespace Formula1.Migrations
{
    public partial class TeamsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamBase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamChief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamChassis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamPowerUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamWorldChampionships = table.Column<int>(type: "int", nullable: false),
                    TeamPolePositions = table.Column<int>(type: "int", nullable: false),
                    TeamFastestLaps = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
