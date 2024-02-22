using MediatR;
using Service.Dtos;
using Service.Interfaces;

namespace Service.Features.Produit.Queries
{
    public class ProduitListQueryHandler : IRequestHandler<ProduitListQuery, IEnumerable<ProduitGetDTO>>
    {
        private readonly IUnitOfService _service;
        public ProduitListQueryHandler(IUnitOfService service) => 
            _service = service;


        public async Task<IEnumerable<ProduitGetDTO>> Handle(ProduitListQuery request, CancellationToken cancellationToken)
        {
            return await _service.ProduitService.FindAllAsync();
        }
    }
}
