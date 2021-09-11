using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineMania.Migrations
{
    public partial class Migrations : Migration
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
                values: new object[] { 15, "The Croods, who are in search of a safer habitat, chance upon a walled lush green oasis, built by the more sophisticated Bettermans. They are welcomed at first, but when the Croods patriarch Grug eats a forbidden fruit, all hell breaks loose.", "Series", "movieeight.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Croods" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 14, "Based on a true story - when the Teague family is devastated by life-altering news, their friend decides to put his life on hold to live with them.", "Horror", "movieseven.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Our Friend" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 13, "A petty car thief Bill O’Neal becomes an FBI informant and agrees to infiltrate a black revolutionary party called ‘The Black Panthers,’ in exchange for his freedom. But will he come out unscathed from the consequences of his actions, at a time when white-supremacy and police action against the black revolutionaries was at its peak, in the late-1960s Chicago?", "Horror", "moviesix.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Judas And The Black Messiah" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 12, "Some five hundred years after the ominous dark monsters called the Druun, return to wreak havoc on earth, it's up to Raya, an intrepid warrior princess to track down the last dragon and put a definite end to the Druun terror.", "Horror", "moviefive.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raya And The Last Dragon Movie" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 11, "Following the death of her husband and losing her livelihood to the Great Recession, Fern (Frances McDormand), a woman in her 60’s, converts her RV van into her home and opts for a nomadic life. She wanders through the vast expanses of the US, taking up seasonal low-wage jobs to sustain her minimalistic lifestyle", "Drama", "moviefour.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nomadland Movie" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 10, "Minari is a semi-autobiographical take on writer and director Lee Isaac Chung’s life in a family of Korean immigrants in Arkansas in the 1980s. The story follows the Yi family — father (Steven Yeun), mother, their two children, and grandmother — who move to Arkansas where the dad decides to become a farmer. His former job as a chicken sexer doesn’t pay him much.", "Drama", "moviethree.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minari Movie" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 16, "Paranormal investigators Ed and Lorraine Warren are up against one of the most evil and demonic forces, who will stop at nothing to accomplish its unholy mission. Fighting this evil entity could take everything they have.", "Series", "movienine.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Mauritanian" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 9, "Paranormal investigators Ed and Lorraine Warren are up against one of the most evil and demonic forces, who will stop at nothing to accomplish its unholy mission. Fighting this evil entity could take everything they have.", "Drama", "movietwo.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 7, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Animation", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 6, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "Animation", "pulp_fiction.jpg", new DateTime(1994, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 5, "78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway", "Animation", "up.jpg", new DateTime(2009, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Up" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 4, "A family falls victim to a group of mutated cannibals in a desert far away from civilization.", "Action", "hills_have_eyes.jpg", new DateTime(2006, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hills Have Eyes" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 3, "Beca, a freshman at Barden University, is cajoled into joining The Bellas, her school's all-girls singing group. Injecting some much needed energy into their repertoire, The Bellas take on their male rivals in a campus competition", "Action", "black_widow.jpg", new DateTime(2013, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pitch Perfect" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 2, "A family man is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.", "Action", "the_tomorrow_war.jpg", new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Tomorrow War" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 8, "Anthony’s (Hopkins) reluctance to be looked after by a carer, makes him increasingly vulnerable to the tricks that his mind plays on him. Writer-director Florian Zeller takes us on a chilling ride into Anthony’s volatile world, as he struggles to come to terms with the reality of his mental health condition that has blurred the lines between his past, present and future.", "Drama", "movione.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Father Movie" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 17, "Kong needs to protect the planet from Godzilla, who goes on an unprovoked rampage.", "Series", "movieten.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Godzilla Vs. Kong Movie" });
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
