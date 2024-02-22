using AutoMapper;
using Data.Entities;
using Service.Dtos;

namespace Service.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            //Produit Mapping
            CreateMap<Produit, ProduitGetDTO>();
            CreateMap<ProduitPostDTO, Produit>();
            //CreateMap<ProduitPutDTO, Produit>();

        }
    }
}
