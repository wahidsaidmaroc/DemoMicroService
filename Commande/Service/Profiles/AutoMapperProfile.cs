using AutoMapper;
using Data.Entities;
using Service.Features.Commande.Queries.GetDetail;

namespace Service.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Commande, CommandeDto>();

        }
    }
}
