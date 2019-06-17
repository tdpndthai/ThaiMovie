using System;
using System.ComponentModel.DataAnnotations;

namespace ThaiMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Ngày Phát Hành")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Số lượng còn lại")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        [Display(Name = "Số lượng sẵn có")]
        public byte NumberAvailable { get; set; }
    }
}