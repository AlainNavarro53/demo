using Demo.Business.Interfaces.Repositories;
using Demo.Data.Contexts;
using Demo.Entities;

namespace Demo.Business.Repository;

public class EventoRepository(ApplicationContext dbContext)
    : GenericRepository<Evento>(dbContext), IEventoRepository
{
    private readonly ApplicationContext _dbContext = dbContext;
}