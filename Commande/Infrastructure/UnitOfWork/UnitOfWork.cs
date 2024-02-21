
using Infrastructure.Context;
using Infrastructure.Interfaces;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _dbContext;
        public ICommandeRepos CommandeRepos { get; private set; }
        public IProduitRepos ProduitRepos { get; private set; }

        public UnitOfWork(MyDbContext dbContext)
        {
            _dbContext = dbContext;
            CommandeRepos = new CommandeRepository(_dbContext);
            ProduitRepos = new  ProduitRepository(_dbContext);
        }
        public void Commit()
            => _dbContext.SaveChanges();

        public async Task CommitAsync()
            => await _dbContext.SaveChangesAsync();

        public void Rollback()
            => _dbContext.Dispose();

        public async Task RollbackAsync()
            => await _dbContext.DisposeAsync();
    }
}
