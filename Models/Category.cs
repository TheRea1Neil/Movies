using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Category
    {
        [Key]
        public int Mission07_CategoryId { get; set; }
        public string? Mission07_Category { get; set; }

      
    }
}
