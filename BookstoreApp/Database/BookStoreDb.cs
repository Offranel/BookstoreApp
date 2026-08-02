using BookstoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookstoreApp.Database;

internal class BookStoreDb : DbContext 
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookstoreDb;Integrated Security=True;Encrypt=false;Trust Server Certificate=False;");
    }                               
    // Add entaties to track in the database as DbSets below
    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

       
        modelBuilder.Entity<Genre>().HasData(
            new Genre { GenreId = 1, Name = "Fiction" },
            new Genre { GenreId = 2, Name = "Non-Fiction" },
            new Genre { GenreId = 3, Name = "Science Fiction" },
            new Genre { GenreId = 4, Name = "Fantasy" },
            new Genre { GenreId = 5, Name = "Mystery" },
            new Genre { GenreId = 6, Name = "Romance" },
            new Genre { GenreId = 7, Name = "Historical" },
            new Genre { GenreId = 8, Name = "Biography" },
            new Genre { GenreId = 9, Name = "Self-Help" },
            new Genre { GenreId = 10, Name = "Children's" }
        );
    }
}
