/*
 * Movie.cs
 * Author: Raymond Lawson
 */

///Summary: This class is a data model for use with the database.

using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        //Declare variables.
        public int ID { get; set; }  //Required by DB for the primary key.
        public string Title { get; set; }

        [DataType(DataType.Date)]  //The DataType attribute specifies the type of the data (Date).
                                   //With this the user is not required to enter time info in the date field.
                                   //Only the date is displayed, not time information.
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
