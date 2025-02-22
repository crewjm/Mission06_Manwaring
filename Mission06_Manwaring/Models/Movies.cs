using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mission06_Manwaring.Models;

// form elements with specific features being required
public class Movies
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MovieId { get; set; }
    
    [ForeignKey("CategoryID")]
    public int? CategoryID { get; set; }
    public Category? Category { get; set; }
    
    [Required] 
    public string Title { get; set; }
    
    [Required] 
    [Range(1888,int.MaxValue)]
    public int Year { get; set; }
    public string? Director { get; set; }
    public string? Rating { get; set; }
    
    [Required]
    public bool Edited { get; set; }
    public string? LentTo { get; set; }
    
    [Required]
    public bool CopiedToPlex { get; set; }
    
    // max length below, bools above
    
    [MaxLength(25)]
    public string? Notes { get; set; }
}