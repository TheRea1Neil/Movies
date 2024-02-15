using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Mission06_MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mission06_Title = table.Column<string>(type: "TEXT", nullable: false),
                    Mission06_Category = table.Column<string>(type: "TEXT", nullable: false),
                    Mission06_Director = table.Column<string>(type: "TEXT", nullable: false),
                    Mission06_Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Mission06_Rating = table.Column<string>(type: "TEXT", nullable: false),
                    Mission06_Edited = table.Column<bool>(type: "INTEGER", nullable: true),
                    Mission06_Lent_To = table.Column<string>(type: "TEXT", nullable: true),
                    Mission06_Notes = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Mission06_MovieId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
