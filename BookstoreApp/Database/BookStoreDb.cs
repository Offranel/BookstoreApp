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
}
