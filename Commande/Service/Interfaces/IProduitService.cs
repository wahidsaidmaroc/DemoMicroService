using Data.Entities;

namespace Service.Interfaces
{
    public interface IProduitService
    {
       Task AddAsync(Produit produit);
    }
}
