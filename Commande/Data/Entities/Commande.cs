using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace Data.Entities;

[Table("Com_Commande" , Schema ="dbo")]
public class Commande : BaseEntite
{
    public Commande() 
    {
        CommandeDetails = new HashSet<CommandeDetail>();
    }


    [Required]
    public DateTime DateCommande { get; set; }
    [Required]
    [StringLength(10)]
    public string RefCommande { get; set; } = string.Empty;
    [Required]
    public int IdClient { get; set; }
    public decimal MontantHT { get; set; }
    public bool EstPaye { get; set; }
    public decimal Taxe { get; set; }
    public decimal MontantTTC { get; set; }

    //[InverseProperty("Com_CommandeDetail")]
    public virtual ICollection<CommandeDetail> CommandeDetails { get; set; }
}
