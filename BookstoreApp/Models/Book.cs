using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Security.Permissions;

namespace BookstoreApp.Models
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

        /// <summary>
        /// The 13 character ISBN number.No dashes allowed, digits only
        /// </summary>
        public required string ISBN { get; set; }
        /// <summary>
        /// The optional user facing description of the book
        /// </summary>
        public string? Description {  get; set; }
        /// <summary>
        /// A display-friendly representation used by UI lists
        /// </summary>
        public string Display => $"{Title} ({ISBN}) - {Price:c2}";
        public override string ToString()
        {
            return $"{Title} - {Price:c2} ";
        }
    }
       
}
