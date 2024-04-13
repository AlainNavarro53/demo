using System.Linq.Expressions;
using Demo.Business.Interfaces.Repositories;
using Demo.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Demo.Business.Repository;

public class GenericRepository<Entity>(ApplicationContext dbContext) : IGenericRepository<Entity>
    where Entity : class
{
    private readonly ApplicationContext _dbContext = dbContext;

    public async Task AddAsync(Entity entity, CancellationToken cancellationToken)
    {
        await _dbContext.Set<Entity>().AddAsync(entity, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task EditAsync(Entity entity, CancellationToken cancellationToken)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(Entity entity, CancellationToken cancellationToken)
    {
        _dbContext.Set<Entity>().Remove(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<List<Entity>> GetAllAsync()
    {
        return await _dbContext.Set<Entity>().ToListAsync();
    }

    public async Task<List<Entity>> GetAllWithIncludeAsync(List<string> properties)
    {
        var query = _dbContext.Set<Entity>().AsQueryable();

        foreach (var property in properties) query = query.Include(property);

        return await query.ToListAsync();
    }

    public async Task<Entity> GetByIdAsync(int id)
    {
        return await _dbContext.Set<Entity>().FindAsync(id);
    }

    public IQueryable<Entity> Find(Expression<Func<Entity, bool>> predicate)
    {
        IQueryable<Entity> query = _dbContext.Set<Entity>();
        return query.Where(predicate);
    }

    public IQueryable<Entity> AsQueryable()
    {
        return _dbContext.Set<Entity>().AsNoTracking();
    }
}