using Microsoft.EntityFrameworkCore;

namespace Movies.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) 
        { 
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category { Mission07_CategoryId = 1, Mission07_Category = "Miscellaneous" },
                    new Category { Mission07_CategoryId = 2, Mission07_Category = "Drama" },
                    new Category { Mission07_CategoryId = 3, Mission07_Category = "Television" },
                    new Category { Mission07_CategoryId = 4, Mission07_Category = "Horror/Suspense" },
                    new Category { Mission07_CategoryId = 5, Mission07_Category = "Comedy" },
                    new Category { Mission07_CategoryId = 6, Mission07_Category = "Family" },
                    new Category { Mission07_CategoryId = 7, Mission07_Category = "Action/Adventure" },
                    new Category { Mission07_CategoryId = 8, Mission07_Category = "VHS" }
  );
        }
    }
}
