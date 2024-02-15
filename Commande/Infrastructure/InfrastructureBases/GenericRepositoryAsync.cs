using Infrastructure.Context;

namespace Infrastructure.InfrastructureBases;
public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
{

    #region Vars / Props

    protected readonly MyDbContext _dbContext;

    #endregion

    #region Constructor(s)
    public GenericRepositoryAsync(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    #endregion

    #region Methods

    #endregion

    #region Actions
    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public virtual async Task<T> AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public virtual async Task UpdateAsync(T entity)
    {
        _dbContext.Set<T>().Update(entity);
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task DeleteAsync(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    #endregion
}
