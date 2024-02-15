using Data.Entities;
using Infrastructure.Context;
using Infrastructure.InfrastructureBases;
using Infrastructure.Interfaces;


namespace Infrastructure.Repository
{
    public class CommandeRepository : GenericRepositoryAsync<Commande>, ICommandeRepos
    {
        public CommandeRepository(MyDbContext context) : base(context)
        {

        }
    }
}
