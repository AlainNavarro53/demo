using Demo.Business.ViewModels.Comisario;

namespace Demo.Business.Interfaces.Services;

public interface IComisarioService
{
    Task<List<ComisarioViewModel>> GetList(FiltroComisarioViewModel filtroComisarioViewModel,
        CancellationToken cancellationToken);

    Task Create(CreateComisarioViewModel vm, CancellationToken cancellationToken);
    Task<ComisarioViewModel> GetById(int id);
    Task Update(UpdateComisarioViewModel vm, CancellationToken cancellationToken);
    Task Delete(int id, CancellationToken cancellationToken);
}