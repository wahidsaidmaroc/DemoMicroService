using AutoMapper;
using Data.Entities;
using Infrastructure.Interfaces;
using Infrastructure.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Service.Features.Commande.Queries.GetDetail
{
    public class GetCommandeDetailQueryHandler : IRequestHandler<GetDetailCommandeQuery, CommandeDto>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public GetCommandeDetailQueryHandler(IMapper mapper,
            IUnitOfWork uow)
        {
            _mapper = mapper;
            _uow = uow;
        }
        public async Task<CommandeDto> Handle(GetDetailCommandeQuery request, CancellationToken cancellationToken)
        {
            var command = await _uow.CommandeRepos.GetAsync(a => a.Id == request.CommandeId);

            return _mapper.Map<CommandeDto>(command);

        }
    }
}
