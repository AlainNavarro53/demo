using Demo.Business.Interfaces.Repositories;
using Demo.Data.Contexts;
using Demo.Entities;

namespace Demo.Business.Repository;

public class SedeOlimpicaRepository(ApplicationContext dbContext)
    : GenericRepository<SedeOlimpica>(dbContext), ISedeOlimpicaRepository
{
    private readonly ApplicationContext _dbContext = dbContext;
}