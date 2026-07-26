using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Security.Permissions;

namespace BookstoreApp
{
    /// <summary>
    /// Represents an indiduel book for sale
    /// </summary>
    
    public class Book
    {
        /// <summary>
        /// The primary key/unique identifier for the book 
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The title of the book
        /// </summary>
        public required string Title  { get; set; }

        /// <summary>
        /// Sales price of the book
        /// </summary>
        public double Price { get; set; }
    }
}
