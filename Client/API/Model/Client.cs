namespace API.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public DateTime DateCreation { get; set; }
        public decimal Solde { get; set; }
        public bool EstCredit { get; set; }

    }
}
