using System.ComponentModel.DataAnnotations;
namespace Mission06_Manwaring.Models;

//Below is category class for table

public class Category
{
    [Key]
    public int? CategoryID { get; set; }
    public string? CategoryName { get; set; }
}