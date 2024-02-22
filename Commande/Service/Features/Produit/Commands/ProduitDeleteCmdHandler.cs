using MediatR;
using Service.Interfaces;

namespace Service.Features.Produit.Commands;

public class ProduitDeleteCmdHandler : IRequestHandler<ProduitDeleteCmd, bool>
{
    private readonly IUnitOfService _service;
    public ProduitDeleteCmdHandler(IUnitOfService service) => _service = service;




    public async Task<bool> Handle(ProduitDeleteCmd request, CancellationToken cancellationToken)
    {
        bool success = await _service.ProduitService.DeleteAsync(request.Id);
        return success;
    }
}