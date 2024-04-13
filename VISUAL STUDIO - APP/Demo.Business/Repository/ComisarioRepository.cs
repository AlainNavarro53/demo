using Demo.Business.Interfaces.Repositories;
using Demo.Data.Contexts;
using Demo.Entities;

namespace Demo.Business.Repository;

public class ComisarioRepository(ApplicationContext dbContext)
    : GenericRepository<Comisario>(dbContext), IComisarioRepository
{
    private readonly ApplicationContext _dbContext = dbContext;
}