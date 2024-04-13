using Demo.Business.Interfaces.Repositories;
using Demo.Data.Contexts;
using Demo.Entities;

namespace Demo.Business.Repository;

public class UsuarioRepository(ApplicationContext dbContext) : GenericRepository<Usuario>(dbContext), IUsuarioRepository
{
    private readonly ApplicationContext _dbContext = dbContext;
}