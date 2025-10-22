using System.ComponentModel.DataAnnotations;

namespace MovieReviewSite.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Genre { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Url]
        public string? PosterUrl { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}