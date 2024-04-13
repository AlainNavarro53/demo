using Demo.Business.Interfaces.Repositories;
using Demo.Business.Interfaces.Services;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Business.Services;

public class UsuarioService(IUsuarioRepository usuarioRepository) : IUsuarioService
{
    public async Task<Usuario?> Login(string userName, string password, CancellationToken cancellationToken)
    {
        // Verificamos credenciales con Identity
        //var user = await usuarioRepository.Find(p => p.Username == userName)
        //    .FirstOrDefaultAsync(cancellationToken);

        //if (user is null)
        //    throw new Exception("El usuario no existe.");

        //if (password != Crypter.DecryptString("_s1Gc0mTh4Sh", user.Password))
        //    throw new Exception("Las credenciales son incorrectas.");

        return await usuarioRepository.Find(p => p.Username == userName)
            .FirstOrDefaultAsync(cancellationToken);
    }
}