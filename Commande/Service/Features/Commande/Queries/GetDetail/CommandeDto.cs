

namespace Service.Features.Commande.Queries.GetDetail
{
    public class CommandeDto
    {
        public int Id { get; set; }
        public DateTime DateCommande { get; set; }
        public string RefCommande { get; set; } = string.Empty;
        public int IdClient { get; set; }
        public decimal MontantHT { get; set; }
        public bool EstPaye { get; set; }
        public decimal Taxe { get; set; }
        public decimal MontantTTC { get; set; }
    }
}
