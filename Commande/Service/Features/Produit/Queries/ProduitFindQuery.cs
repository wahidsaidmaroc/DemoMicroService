using MediatR;
using Service.Dtos;

namespace Service.Features.Produit.Queries;

public record ProduitFindQuery(int Id) : IRequest<ProduitGetDTO>;