using MediatR;
using Service.Dtos;

namespace Service.Features.Produit.Commands;

public class ProduitCreateCmd: IRequest<ProduitGetDTO>
{
    public string Nom{ get; set; }
    public string Description { get; set; }
    public decimal Prix { get; set; }
    
}

