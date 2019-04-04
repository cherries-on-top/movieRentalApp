using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalApp.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public GenreDto Genre { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Required]
        public DateTime Released { get; set; }

        public DateTime AddedToDatabase { get; set; }

        [Required]
        public int Stock { get; set; }
    }
}