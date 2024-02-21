
using Infrastructure.Interfaces;
using System.Windows.Input;

namespace Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICommandeRepos CommandeRepos { get; }
        IProduitRepos ProduitRepos { get; }
        void Commit();
        Task CommitAsync();
        void Rollback();
        Task RollbackAsync();
    }
}