using Demo.Entities;

namespace Demo.Business.Interfaces.Services;

public interface IUsuarioService
{
    Task<Usuario?> Login(string userName, string password, CancellationToken cancellationToken);
}