﻿using Data.Entities;
using Infrastructure.Context;
using Infrastructure.InfrastructureBases;
using Infrastructure.Interfaces;

namespace Infrastructure.Repository
{
    public class ProduitRepository : GenericRepositoryAsync<Produit>, IProduitRepos
    {
        public ProduitRepository(MyDbContext context) : base(context)
        {

        }
    }
}
