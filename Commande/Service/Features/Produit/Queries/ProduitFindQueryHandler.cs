using MediatR;
using Service.Dtos;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Produit.Queries;




public class ProduitFindQueryHandler : IRequestHandler<ProduitFindQuery, ProduitGetDTO>
{
    private readonly IUnitOfService _service;
    public ProduitFindQueryHandler(IUnitOfService service) => _service = service;

    public async Task<ProduitGetDTO> Handle(ProduitFindQuery request, CancellationToken cancellationToken)
    {
        var p = await _service.ProduitService.FindAsync(request.Id);
        return p;
    }
}