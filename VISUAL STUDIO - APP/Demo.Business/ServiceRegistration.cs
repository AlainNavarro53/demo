using Demo.Business.Interfaces.Repositories;
using Demo.Business.Interfaces.Services;
using Demo.Business.Repository;
using Demo.Business.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Business;

public static class ServiceRegistration
{
    public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
    {
        #region Repositories

        services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddTransient<IUsuarioRepository, UsuarioRepository>();
        services.AddTransient<ISedeOlimpicaRepository, SedeOlimpicaRepository>();
        services.AddTransient<IComisarioRepository, ComisarioRepository>();
        services.AddTransient<IEventoRepository, EventoRepository>();

        #endregion

        #region services

        services.AddTransient<IUsuarioService, UsuarioService>();
        services.AddTransient<ISedeOlimpicaService, SedeOlimpicaService>();
        services.AddTransient<IComisarioService, ComisarioService>();
        services.AddTransient<IEventoService, EventoService>();

        #endregion
    }
}