using Microsoft.EntityFrameworkCore;
using Mission06_Manwaring.Models;
    
namespace Mission06_Manwaring.Models;

//model for db

public class MovieAppContext : DbContext
{
    public MovieAppContext(DbContextOptions<MovieAppContext> options) : base(options) //constructor
    {
    }
    
    public DbSet<Movies> Movies { get; set; }
}