using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class BaseEntite
{
    [Key]
    public int Id { get; set; }
    public DateTime DateCreation { get; set; }
    public DateTime LasetUpdate { get; set; }
    [Required]
    public int IdCreateur { get; set; }
}
