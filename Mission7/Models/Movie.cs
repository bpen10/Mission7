using System.ComponentModel.DataAnnotations;

namespace Mission7.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public int? CategoryId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1888, 9999, ErrorMessage = "Year must be 1888 or later")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Edited field is required")]
        [Range(0, 1, ErrorMessage = "Edited must be 0 or 1")]
        public int Edited { get; set; }

        public string? LentTo { get; set; }

        [Required(ErrorMessage = "CopiedToPlex field is required")]
        [Range(0, 1, ErrorMessage = "CopiedToPlex must be 0 or 1")]
        public int CopiedToPlex { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}