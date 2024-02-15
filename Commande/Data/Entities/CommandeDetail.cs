using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

[Table("Com_CommandeDetail", Schema = "dbo")]

public class CommandeDetail : BaseEntite
{
    public int IdCommande { get; set; }
    public int IdProduit { get; set; }
    public decimal PU { get; set; }
    public int Qnt { get; set; }
    public decimal Montant { get; set; }
    [ForeignKey("IdCommande")]
    //[InverseProperty("Com_Commande")]
    public Commande Commandes { get; set; }
}
