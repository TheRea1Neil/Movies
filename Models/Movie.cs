using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Mission06_MovieId { get; set; }
     
        public string? Mission06_Title { get; set; }

        [Required]        
        
        public int Mission07_CategoryId { get; set; }
        [ForeignKey("Mission07_CategoryId")]
        public Category? Mission07_Category { get; set; }
    
        public string? Mission06_Director { get; set; }
        [Required]
        public int Mission06_Year { get; set; }
     
        public string? Mission06_Rating { get; set; }

        public int? CopiedToPlex {  get; set; }
        public int? Mission06_Edited { get; set; }
        public string? Mission06_Lent_To { get; set; }
        [StringLength(25)]
        public string? Mission06_Notes { get; set; }
    }
}
