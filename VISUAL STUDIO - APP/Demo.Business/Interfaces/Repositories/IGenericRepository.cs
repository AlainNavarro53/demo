using System.Linq.Expressions;

namespace Demo.Business.Interfaces.Repositories;

public interface IGenericRepository<Entity> where Entity : class
{
    Task AddAsync(Entity entity, CancellationToken cancellationToken);
    Task EditAsync(Entity entity, CancellationToken cancellationToken);
    Task DeleteAsync(Entity entity, CancellationToken cancellationToken);
    Task<List<Entity>> GetAllAsync();
    Task<List<Entity>> GetAllWithIncludeAsync(List<string> properties);
    Task<Entity> GetByIdAsync(int id);
    IQueryable<Entity> Find(Expression<Func<Entity, bool>> predicate);
    IQueryable<Entity> AsQueryable();
}