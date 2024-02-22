
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

[Table("Pr_Produit", Schema = "dbo")]

public class Produit : BaseEntite
{
    public string Nom { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Prix { get; set; } = 0;
}
