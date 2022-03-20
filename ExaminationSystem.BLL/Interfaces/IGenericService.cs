using ExaminationSystem.Entities.Interfaces;

namespace ExaminationSystem.BLL.Interfaces;

public interface IGenericService<T>
         where T : class, IEntityBase, new()
{
    public Task<IEnumerable<T>> GetAllAsync(params string[] inculudes);
    public Task<IEnumerable<T>> GetAllWithDeletedAsync();
    public ValueTask<T?> GetByIdAsync(Guid id);

    public Task<T> AddAsync(T entity);
    public Task UpdateAsync(T entity);
    public Task RemoveAsync(T entity, bool hardDelete = false);
    Task<int> SaveChangesAsync();
}