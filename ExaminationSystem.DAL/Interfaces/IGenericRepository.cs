using ExaminationSystem.Entities.Interfaces;

namespace ExaminationSystem.DAL.Interfaces;

public interface IGenericRepository<T>
   where T : class, IEntityBase, new()
{
    Task<T> AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);

    Task UpdateAsync(T entity);
    Task RemoveAsync(T entity, bool hardDelete = false);

    Task<IEnumerable<T>> GetAllAsync(params string[] inculudes);
    Task<IEnumerable<T>> GetAllWithDeletedAsync();
    ValueTask<T?> GetByIdAsync(Guid id);

    Task<int> SaveChangesAsync();
}
