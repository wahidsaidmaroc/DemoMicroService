using MediatR;
using Service.Dtos;
using Service.Interfaces;

namespace Service.Features.Produit.Commands;

public class ProduitCreateCmdHandler : IRequestHandler<ProduitCreateCmd, ProduitGetDTO>
{
    private readonly IUnitOfService _service;
    public ProduitCreateCmdHandler(IUnitOfService service) => _service = service;

    public async Task<ProduitGetDTO> Handle(ProduitCreateCmd request, CancellationToken cancellationToken)
    {
        var validatorProduit = new ProduitCreateCmdValidator();
        var resule = await validatorProduit.ValidateAsync(request);
        if (resule.Errors.Any())
        {
            var erreur = resule.Errors.Select(a => a.ErrorMessage).ToList();


            throw new Exception();
        }

        var produitPostDTO = new ProduitPostDTO() 
        { Nom =  request.Nom, Description =  request.Description, Prix = request.Prix };
        var produit = await _service.ProduitService.CreateAsync(produitPostDTO);
        return produit;
    }
}