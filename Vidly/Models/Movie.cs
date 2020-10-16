using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Movie
    {
        //ID
        public int Id { get; set; }
        //Title
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        //release Date
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        //Genre
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]

        //Price
        public decimal Price { get; set; }


        //Rating
        public string FilmRating { get; set; }
    }
}
