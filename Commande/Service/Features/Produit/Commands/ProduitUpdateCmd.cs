using MediatR;
using Service.Dtos;

namespace Service.Features.Produit.Commands;

public class ProduitUpdateCmd : IRequest<ProduitGetDTO>
{

    public int Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Prix { get; set; }

}