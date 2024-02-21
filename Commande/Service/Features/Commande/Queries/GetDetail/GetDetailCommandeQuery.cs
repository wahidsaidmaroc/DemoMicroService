

using MediatR;

namespace Service.Features.Commande.Queries.GetDetail
{
    public class GetDetailCommandeQuery : IRequest<CommandeDto>
    {

        public int CommandeId { get; set; }

    }
}
