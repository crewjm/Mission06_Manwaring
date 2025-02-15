using System.ComponentModel.DataAnnotations;
namespace Mission06_Manwaring.Models;

// form elements with specific features being required
public class Movies
{
    [Key]
    [Required]
    public int MovieId { get; set; }
    
    [Required] 
    public string Category { get; set; }
    
    [Required] 
    public string Title { get; set; }
    
    [Required] 
    public int Year { get; set; }
    
    [Required] 
    public string Director { get; set; }
    
    [Required]
    public string Rating { get; set; }
    
    public bool? Edited { get; set; }
    public string? LentTo { get; set; }
    
    // max length below, bools above
    
    [MaxLength(25)]
    public string? Notes { get; set; }
}