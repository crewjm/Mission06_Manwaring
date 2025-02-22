using Microsoft.EntityFrameworkCore;
using Mission06_Manwaring.Models;
    
namespace Mission06_Manwaring.Models;

//model for db

public class MovieAppContext : DbContext
{
    public MovieAppContext(DbContextOptions<MovieAppContext> options) : base(options) //constructor
    {
    }
    
    //Table connection and dummy data
    
    public DbSet<Movies> Movies { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) //Seed data
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryID = 1, CategoryName = "Drama" },
            new Category { CategoryID = 2, CategoryName = "Comedy" },
            new Category { CategoryID = 3, CategoryName = "Action" },
            new Category { CategoryID = 4, CategoryName = "Adventure" },
            new Category { CategoryID = 5, CategoryName = "Horror" },
            new Category { CategoryID = 6, CategoryName = "Thriller" },
            new Category { CategoryID = 7, CategoryName = "Sci-Fi" },
            new Category { CategoryID = 8, CategoryName = "Romance" },
            new Category { CategoryID = 9, CategoryName = "Mystery" },
            new Category { CategoryID = 10, CategoryName = "Family" }
        );
    }
}