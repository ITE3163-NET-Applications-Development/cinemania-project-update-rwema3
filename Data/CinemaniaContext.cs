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
                    Genre = "Sci-Fi",
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
                    Genre = "Comedy",
                    ReleaseDate = DateTime.Parse("2013-09-24")
                },
                new Movie
                {
                    Id = 4,
                    Title = "The Hills Have Eyes",
                    Description = "A family falls victim to a group of mutated cannibals " +
                                  "in a desert far away from civilization.",
                    ImageName = "hills_have_eyes.jpg",
                    Genre = "Horror",
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
                    Genre = "Crime",
                    ReleaseDate = DateTime.Parse("1994-12-05")
                },
                new Movie
                {
                    Id = 7,
                    Title = "Rocky",
                    Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion " +
                                  "in a bout in which he strives to go the distance for his self-respect.",
                    ImageName = "rocky.jpg",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                }
            };
          
            modelBuilder.Entity<Movie>().HasData(movies);
            base.OnModelCreating(modelBuilder);
        }
    }
}