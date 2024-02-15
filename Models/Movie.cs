using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        public int Mission06_MovieId { get; set; }

        public string Mission06_Title { get; set; }

        public string Mission06_Category { get; set; }

        public string Mission06_Director { get; set; }

        public int Mission06_Year { get; set; }

        public string Mission06_Rating { get; set; }

        public bool Mission06_Edited { get; set; }
        public string Mission06_Lent_To { get; set; }
        [StringLength(25)]
        public string Mission06_Notes { get; set; }
    }
}
