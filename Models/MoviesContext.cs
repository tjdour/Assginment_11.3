using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Assginment_11._3.Models
{
    public class MoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=movies.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, GenreName = "Action" },
                new Genre { GenreId = 2, GenreName = "Comedy" },
                new Genre { GenreId = 3, GenreName = "Drama" },
                new Genre { GenreId = 4, GenreName = "Science Fiction" }
    );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "Speed", Year = 1994, GenreId = 1 },
                new Movie { MovieId = 2, Title = "Taken", Year = 2008, GenreId = 1 },
                new Movie { MovieId = 3, Title = "Step Brothers", Year = 2008, GenreId = 2 },
                new Movie { MovieId = 4, Title = "Mean Girls", Year = 2004, GenreId = 2 },
                new Movie { MovieId = 5, Title = "Manchester by the Sea", Year = 2016, GenreId = 3 },
                new Movie { MovieId = 6, Title = "Moonlight", Year = 2016, GenreId = 3 },
                new Movie { MovieId = 7, Title = "The Shining", Year = 1980, GenreId = 4 },
                new Movie { MovieId = 8, Title = "A Nightmare on Elm Street", Year = 1984, GenreId = 4 }
            );
        }

    }
}
