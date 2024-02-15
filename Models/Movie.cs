using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Mission06_MovieId { get; set; }
        [Required]
        public string Mission06_Title { get; set; }
        [Required]
        public string Mission06_Category { get; set; }
        [Required]
        public string Mission06_Director { get; set; }
        [Required]
        public int Mission06_Year { get; set; }
        [Required]
        public string Mission06_Rating { get; set; }

        public bool Mission06_Edited { get; set; }
        public string? Mission06_Lent_To { get; set; }
        [StringLength(25)]
        public string Mission06_Notes { get; set; }
    }
}
