using Microsoft.EntityFrameworkCore;
using System;

namespace Vidly.Models
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
               new Movie
               {
                   Id = 1,
                   Title = "When Harry Met Sally",
                   ReleaseDate = DateTime.Parse("1989-2-12"),
                   Genre = "Romantic Comedy",
                   Price = 7.99M,
                   FilmRating = "A"
               },

                   new Movie
                   {
                       Id = 2,
                       Title = "Ghostbusters ",
                       ReleaseDate = DateTime.Parse("1984-3-13"),
                       Genre = "Comedy",
                       Price = 8.99M,
                       FilmRating = "PG"
                   },

                   new Movie
                   {
                       Id = 3,
                       Title = "Ghostbusters 2",
                       ReleaseDate = DateTime.Parse("1986-2-23"),
                       Genre = "Comedy",
                       Price = 9.99M,
                       FilmRating = "U"
                   },

                   new Movie
                   {
                       Id = 4,
                       Title = "Rio Bravo",
                       ReleaseDate = DateTime.Parse("1959-4-15"),
                       Genre = "Western",
                       Price = 3.99M,
                       FilmRating = "R"
                   }

               );

        }
    }
}
