namespace Service.Dtos;


public record ProduitGetDTO(int Id, string Nom, string Description, decimal Prix);
//public record ProduitPostDTO(string Nom, string Description, decimal Prix);
//public record ProduitPutDTO(int Id, string Nom, string Description, decimal Prix);


public class ProduitPostDTO
{
    public string Nom { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Prix { get; set; }
}

public class ProduitPutDTO
{
    public int Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Prix { get; set; }
}


