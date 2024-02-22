using MediatR;

namespace Service.Features.Produit.Commands;

public record ProduitDeleteCmd(int Id) : IRequest<bool>;