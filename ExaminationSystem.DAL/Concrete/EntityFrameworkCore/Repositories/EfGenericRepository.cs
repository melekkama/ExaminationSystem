using ExaminationSystem.DAL.Interfaces;
using ExaminationSystem.DAL.StringInfos;
using ExaminationSystem.Entities.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Repositories;

public class EfGenericRepository<T> : IGenericRepository<T>
 where T : class, IEntityBase, new()
{
    private readonly DbContext _dbContext;
    private readonly DbSet<T> _table;

    private readonly Guid _systemUserId;

    public EfGenericRepository(DbContext dbContext)
    {
        this._dbContext = dbContext;
        _table = dbContext.Set<T>();
        _systemUserId = Guid.Parse(SystemUserInfo.SystemUserId);
    }


    #region GetAll
    public Task<IEnumerable<T>> GetAllAsync(params string[] inculudes)
    {
        var result = _table.Where(x => !x.IsDeleted);
        foreach (var item in inculudes)
            result = result.Include(item);
        return Task.FromResult(result.AsEnumerable());
    }

    public Task<IEnumerable<T>> GetAllWithDeletedAsync() => Task.FromResult(_table.AsEnumerable());
    #endregion

    #region Get
    public ValueTask<T?> GetByIdAsync(Guid id) => _table.FindAsync(id);
    #endregion


    #region CRUD

    public async Task<T> AddAsync(T entity)
    {
        if (entity.CreatedUserId == Guid.Empty) entity.CreatedUserId = _systemUserId;
        entity.CreatedTime = DateTime.Now;
        await _table.AddAsync(entity);
        return entity;
    }

    public async Task AddRangeAsync(IEnumerable<T> entities)
    {
        foreach (var item in entities)
            await AddAsync(item);
    }

    public async Task UpdateAsync(T entity)
    {
        if (entity.UpdatedUserId == Guid.Empty) entity.UpdatedUserId = _systemUserId;
        entity.UpdatedTime = DateTime.Now;
        await Task.FromResult(_table.Update(entity));
    }

    public async Task RemoveAsync(T entity, bool hardDelete = false)
    {
        if (hardDelete)
            _table.Remove(entity);
        else
        {
            entity.IsDeleted = true;
            await UpdateAsync(entity);
        }
    }

    #endregion

    #region Dispose
    public ValueTask DisposeAsync() => _dbContext.DisposeAsync();
    #endregion

    #region Save
    public Task<int> SaveChangesAsync() => _dbContext.SaveChangesAsync();
    #endregion
}
