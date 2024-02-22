using MediatR;
using Service.Dtos;

namespace Service.Features.Produit.Queries;

public record ProduitListQuery : IRequest<IEnumerable<ProduitGetDTO>>;
