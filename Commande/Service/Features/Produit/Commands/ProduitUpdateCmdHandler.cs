using MediatR;
using Service.Dtos;
using Service.Interfaces;

namespace Service.Features.Produit.Commands;

public class ProduitUpdateCmdHandler : IRequestHandler<ProduitUpdateCmd, ProduitGetDTO>
{
    private readonly IUnitOfService _service;
    public ProduitUpdateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<ProduitGetDTO> Handle(ProduitUpdateCmd request, CancellationToken cancellationToken)
    {
        var produitPutDTO = new ProduitPutDTO
        {Description = request.Description ,
            Nom = request.Nom, Prix = request.Prix , Id = request.Id
        };
        var produit = await _service.ProduitService.UpdateAsync(produitPutDTO);
        return produit;
    }
}