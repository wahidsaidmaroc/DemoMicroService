
using Infrastructure.Context;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _dbContext;



        public UnitOfWork(MyDbContext dbContext)
        {
            _dbContext = dbContext;
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
