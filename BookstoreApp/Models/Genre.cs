using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookstoreApp.Models
{
    /// <summary>
    /// Represents a genre category for books
    /// </summary>
    public  class Genre
    {
        /// <summary>
        /// Primary key for the Genre 
        /// </summary>
        [Key]
        public int GenreId { get; set; }

        /// <summary>
        /// The name of the Genre
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// Books that contain this genre
        /// </summary>
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
