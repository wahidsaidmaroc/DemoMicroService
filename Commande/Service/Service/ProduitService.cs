

using AutoMapper;
using Data.Entities;
using Infrastructure.UnitOfWork;
using Service.Dtos;
using Service.Interfaces;

namespace Service.Service
{
    public class ProduitService : IProduitService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _map;
        public ProduitService(IUnitOfWork uow, IMapper map)
        {
            _uow = uow;
            _map = map;
        }

        public async Task<ProduitGetDTO> CreateAsync(ProduitPostDTO produitPostDTO)
        {
            var produit = _map.Map<Produit>(produitPostDTO);

            produit.DateCreation = DateTime.Now;
            produit.LasetUpdate = DateTime.Now;
            produit.IdCreateur = 1;
            await _uow.ProduitRepos.AddAsync(produit);
            _uow.Commit();
            return _map.Map<ProduitGetDTO>(produit);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            //var entity = 
            //var success = await _uow.ProduitRepos.Remove(entity);
            //await _uow.CommitAsync();
            //return success;
            return true;
        }

        public async Task<IEnumerable<ProduitGetDTO>> FindAllAsync()
        {
            var list = await _uow.ProduitRepos.GetAllAsync();

            if (list is null) return null;
            return _map.Map<IEnumerable<ProduitGetDTO>>(list);
        }

        public async Task<ProduitGetDTO> FindAsync(int id)
        {
            var element = await _uow.ProduitRepos.GetAsync(a => a.Id == id);
            
            if (element is null) return null;
            return _map.Map<ProduitGetDTO>(element);
        }

        public Task<ProduitGetDTO> UpdateAsync(ProduitPutDTO produitPutDTO)
        {
            //var city = _map.Map<Produit>(produitPutDTO);
            //var updatedProduit = await _uow.ProduitRepository.UpdateAsync(city, produitPutDTO);

            //await _uow.CommitAsync();
            //return _map.Map<CityGetDTO>(updatedCity);
            return null;
        }
    }
}
