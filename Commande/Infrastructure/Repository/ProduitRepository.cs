using Data.Entities;
using Infrastructure.Context;
using Infrastructure.InfrastructureBases;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class ProduitRepository : GenericRepositoryAsync<Produit>, IProduitRepos
    {
        private readonly DbSet<Produit> _produit; // access to table directly
        public ProduitRepository(MyDbContext context) : base(context)
        {
            _produit = context.Produits;
        }
    }
}
