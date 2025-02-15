using Microsoft.EntityFrameworkCore;
using Mission06_Manwaring.Models;
    
namespace Mission06_Manwaring.Models;

public class MovieAppContext : DbContext
{
    public MovieAppContext(DbContextOptions<MovieAppContext> options) : base(options)
    {
    }
    
    public DbSet<Movies> Movies { get; set; }
}