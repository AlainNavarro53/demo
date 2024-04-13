using Demo.Business.ViewModels.SedeOlimpica;

namespace Demo.Business.Interfaces.Services;

public interface ISedeOlimpicaService
{
    Task<List<SedeOlimpicaViewModel>> GetList(FiltroSedeOlimpicaViewModel filtroDeporteViewModel,
        CancellationToken cancellationToken);

    Task Create(CreateSedeOlimpicaViewModel vm, CancellationToken cancellationToken);
    Task<SedeOlimpicaViewModel> GetById(int id);
    Task Update(UpdateSedeOlimpicaViewModel vm, CancellationToken cancellationToken);
    Task Delete(int id, CancellationToken cancellationToken);
}