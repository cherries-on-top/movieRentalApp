using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Required]
        public DateTime Released { get; set; }

        public DateTime AddedToDatabase { get; set; }

        [Required]
        [Range(1, 10)]
        public int Stock { get; set; }

        public int NumberAvailable { get; set; }
    }
}