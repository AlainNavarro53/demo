using Demo.Business.ViewModels;

namespace Demo.Business.Interfaces.Services;

public interface IEventoService
{
    Task<List<EventoViewModel>> GetList(CancellationToken cancellationToken);
}