using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movies.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Mission07_CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mission07_Category = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Mission07_CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Mission06_MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mission06_Title = table.Column<string>(type: "TEXT", nullable: true),
                    Mission07_CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Mission06_Director = table.Column<string>(type: "TEXT", nullable: true),
                    Mission06_Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Mission06_Rating = table.Column<string>(type: "TEXT", nullable: true),
                    CopiedToPlex = table.Column<int>(type: "INTEGER", nullable: true),
                    Mission06_Edited = table.Column<int>(type: "INTEGER", nullable: true),
                    Mission06_Lent_To = table.Column<string>(type: "TEXT", nullable: true),
                    Mission06_Notes = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Mission06_MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Categories_Mission07_CategoryId",
                        column: x => x.Mission07_CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Mission07_CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Mission07_CategoryId", "Mission07_Category" },
                values: new object[,]
                {
                    { 1, "Miscellaneous" },
                    { 2, "Drama" },
                    { 3, "Television" },
                    { 4, "Horror/Suspense" },
                    { 5, "Comedy" },
                    { 6, "Family" },
                    { 7, "Action/Adventure" },
                    { 8, "VHS" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Mission07_CategoryId",
                table: "Movies",
                column: "Mission07_CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
