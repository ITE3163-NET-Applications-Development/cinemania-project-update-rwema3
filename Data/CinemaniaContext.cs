using System;
using CineMania.Models;
using Microsoft.EntityFrameworkCore;


namespace CineMania.Data
{
    public class CinemaniaContext : DbContext
    {
        public CinemaniaContext(DbContextOptions<CinemaniaContext> options) : base(options)
        {
            
        }
        
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             var movies = new Movie[]
            {
                new Movie
                {
                    Id = 1,
                    Title = "Black Widow",
                    Description = "A film about Natasha Romanoff in her quests " +
                                  "between the films Civil War and Infinity War.",
                    ImageName = "black_widow.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2021-07-09")
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Tomorrow War",
                    Description = "A family man is drafted to fight in a future war where " +
                                  "the fate of humanity relies on his ability to confront the past.",
                    ImageName = "the_tomorrow_war.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2021-07-02")
                },
                new Movie
                {
                    Id = 3,
                    Title = "Pitch Perfect",
                    Description = "Beca, a freshman at Barden University, is cajoled into joining The Bellas, " +
                                  "her school's all-girls singing group. Injecting some much needed energy into " +
                                  "their repertoire, The Bellas take on their male rivals in a campus competition",
                    ImageName = "black_widow.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2013-09-24")
                },
                new Movie
                {
                    Id = 4,
                    Title = "The Hills Have Eyes",
                    Description = "A family falls victim to a group of mutated cannibals " +
                                  "in a desert far away from civilization.",
                    ImageName = "hills_have_eyes.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2006-11-11")
                },
                new Movie
                {
                    Id = 5,
                    Title = "Up",
                    Description = "78-year-old Carl Fredricksen travels to Paradise Falls in his house " +
                                  "equipped with balloons, inadvertently taking a young stowaway",
                    ImageName = "up.jpg",
                    Genre = "Animation",
                    ReleaseDate = DateTime.Parse("2009-03-01")
                },
                new Movie
                {
                    Id = 6,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of " +
                                  "diner bandits intertwine in four tales of violence and redemption.",
                    ImageName = "pulp_fiction.jpg",
                    Genre = "Animation",
                    ReleaseDate = DateTime.Parse("1994-12-05")
                },
                new Movie
                {
                    Id = 7,
                    Title = "Rocky",
                    Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion " +
                                  "in a bout in which he strives to go the distance for his self-respect.",
                    ImageName = "rocky.jpg",
                    Genre = "Animation",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                new Movie
                {
                    Id = 8,
                    Title = "The Father Movie",
                    Description = "Anthony’s (Hopkins) reluctance to be looked after by a carer, makes him increasingly vulnerable to the tricks that his mind plays on him. Writer-director Florian Zeller takes us on a chilling ride into Anthony’s volatile world, as he struggles to come to terms with the reality of his mental " +
                                  "health condition that has blurred the lines between his past, present and future.",
                    ImageName = "movione.jpg",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                new Movie
                {
                    Id = 9,
                    Title = "The Conjuring",
                    Description = "Paranormal investigators Ed and Lorraine Warren are up against one of the most evil and demonic forces, who will stop at nothing to accomplish its unholy mission. Fighting this evil entity could take everything they have.",
                    Genre = "Drama",
                    ImageName = "movietwo.jpg",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                new Movie
                {
                    Id = 10,
                    Title = "Minari Movie",
                    Description = "Minari is a semi-autobiographical take on writer and director Lee Isaac Chung’s life in a family of Korean immigrants in Arkansas in the 1980s. The story follows the Yi family — father (Steven Yeun), mother, their two children, and grandmother — who move to Arkansas where the dad decides to become a farmer. His former job as a chicken sexer doesn’t pay him much.",
                    ImageName = "moviethree.jpg",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                new Movie
                {
                    Id = 11,
                    Title = "Nomadland Movie",
                    Description = "Following the death of her husband and losing her livelihood to the Great Recession, Fern (Frances McDormand), a woman in her 60’s, converts her RV van into her home and opts for a nomadic life. She wanders through the vast expanses of the US, taking up seasonal low-wage jobs to sustain her minimalistic lifestyle",
                    ImageName = "moviefour.jpg",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                new Movie
                {
                    Id = 12,
                    Title = "Raya And The Last Dragon Movie",
                    Description = "Some five hundred years after the ominous dark monsters called the Druun, return to wreak havoc on earth, it's up to Raya, an intrepid warrior princess to track down the last dragon and put a definite end to the Druun terror.",
                    ImageName = "moviefive.jpg",
                    Genre = "Horror",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                new Movie
                {
                    Id = 13,
                    Title = "Judas And The Black Messiah",
                    Description = "A petty car thief Bill O’Neal becomes an FBI informant and agrees to infiltrate a black revolutionary party called ‘The Black Panthers,’ in exchange for his freedom. But will he come out unscathed from the consequences of his actions, at a time when white-supremacy and police action against the black revolutionaries was at its peak, in the late-1960s Chicago?",
                    ImageName = "moviesix.jpg",
                    Genre = "Horror",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                new Movie
                {
                    Id = 14,
                    Title = "Our Friend",
                    Description = "Based on a true story - when the Teague family is devastated by life-altering news, their friend decides to put his life on hold to live with them.",
                    ImageName = "movieseven.jpg",
                    Genre = "Horror",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                new Movie
                {
                    Id = 15,
                    Title = "The Croods",
                    Description = "The Croods, who are in search of a safer habitat, chance upon a walled lush green oasis, built by the more sophisticated Bettermans. They are welcomed at first, but when the Croods patriarch Grug eats a forbidden fruit, all hell breaks loose.",
                    ImageName = "movieeight.jpg",
                    Genre = "Series",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                new Movie
                {
                    Id = 16,
                    Title = "The Mauritanian",
                    Description = "Paranormal investigators Ed and Lorraine Warren are up against one of the most evil and demonic forces, who will stop at nothing to accomplish its unholy mission." +
                                  " Fighting this evil entity could take everything they have.",
                    ImageName = "movienine.jpg",
                    Genre = "Series",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                new Movie
                {
                    Id = 17,
                    Title = "Godzilla Vs. Kong Movie",
                    Description = "Kong needs to protect the planet from Godzilla, who goes on an unprovoked rampage.",
                    ImageName = "movieten.jpg",
                    Genre = "Series",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                

            };
          
            modelBuilder.Entity<Movie>().HasData(movies);
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
