using System;
using System.ComponentModel.DataAnnotations;  

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [DataType(DataType.Date)]  
        public DateTime ReleaseDate { get; set; }
    }
}
