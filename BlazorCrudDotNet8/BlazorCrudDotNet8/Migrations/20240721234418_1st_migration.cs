using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCrudDotNet8.Migrations
{
    /// <inheritdoc />
    public partial class _1st_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentLevel = table.Column<int>(type: "int", nullable: false),
                    ExperiencePoints = table.Column<int>(type: "int", nullable: false),
                    ExperiencePointsToNextLevel = table.Column<int>(type: "int", nullable: false),
                    TotalGamesPlayed = table.Column<int>(type: "int", nullable: false),
                    TotalWins = table.Column<int>(type: "int", nullable: false),
                    TotalLosses = table.Column<int>(type: "int", nullable: false),
                    FriendsCount = table.Column<int>(type: "int", nullable: false),
                    MessagesSent = table.Column<int>(type: "int", nullable: false),
                    MessagesReceived = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
