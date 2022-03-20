using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.DAL.Interfaces;
using ExaminationSystem.Entities.Interfaces;

namespace ExaminationSystem.BLL.Managers;

public class GenericManager<T> : IGenericService<T>
 where T : class, IEntityBase, new()
{
    private readonly IGenericRepository<T> _genericRepository;

    public GenericManager(IGenericRepository<T> genericRepository)
    {
        _genericRepository = genericRepository;
    }

    public Task<T> AddAsync(T entity) => _genericRepository.AddAsync(entity);

    public Task<IEnumerable<T>> GetAllAsync(params string[] inculudes) => _genericRepository.GetAllAsync(inculudes);

    public Task<IEnumerable<T>> GetAllWithDeletedAsync() => _genericRepository.GetAllWithDeletedAsync();

    public ValueTask<T?> GetByIdAsync(Guid id) => _genericRepository.GetByIdAsync(id);

    public Task RemoveAsync(T entity, bool hardDelete = false) => _genericRepository.RemoveAsync(entity, hardDelete);

    public  Task UpdateAsync(T entity) =>  _genericRepository.UpdateAsync(entity);

    public Task<int> SaveChangesAsync() => _genericRepository.SaveChangesAsync();
}
