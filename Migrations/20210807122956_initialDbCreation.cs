using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineMania.Migrations
{
    public partial class initialDbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: false),
                    Message = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ImageName = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 1, "A film about Natasha Romanoff in her quests between the films Civil War and Infinity War.", "Action", "black_widow.jpg", new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 2, "A family man is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.", "Sci-Fi", "the_tomorrow_war.jpg", new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Tomorrow War" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 3, "Beca, a freshman at Barden University, is cajoled into joining The Bellas, her school's all-girls singing group. Injecting some much needed energy into their repertoire, The Bellas take on their male rivals in a campus competition", "Comedy", "black_widow.jpg", new DateTime(2013, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pitch Perfect" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 4, "A family falls victim to a group of mutated cannibals in a desert far away from civilization.", "Horror", "hills_have_eyes.jpg", new DateTime(2006, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hills Have Eyes" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 5, "78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway", "Animation", "up.jpg", new DateTime(2009, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Up" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 6, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "Crime", "pulp_fiction.jpg", new DateTime(1994, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 7, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
