using Demo.Business.Interfaces.Repositories;
using Demo.Business.Interfaces.Services;
using Demo.Business.ViewModels.Comisario;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Business.Services;

public class ComisarioService(IComisarioRepository comisarioRepository) : IComisarioService
{
    public async Task<List<ComisarioViewModel>> GetList(FiltroComisarioViewModel filtroComisarioViewModel,
        CancellationToken cancellationToken)
    {
        var comisarioQueryLis = comisarioRepository.AsQueryable();

        if (!string.IsNullOrWhiteSpace(filtroComisarioViewModel.Name))
            comisarioQueryLis =
                comisarioQueryLis.Where(p => p.Nombre.ToLower().Contains(filtroComisarioViewModel.Name));

        return await comisarioQueryLis.Select(p => new ComisarioViewModel
        {
            Id = p.Id,
            Nombre = p.Nombre,
            Tipo = p.Tipo,
            EventoNombre = p.Evento.Nombre
        }).ToListAsync(cancellationToken);
    }

    public async Task Create(CreateComisarioViewModel vm, CancellationToken cancellationToken)
    {
        await comisarioRepository.AddAsync(new Comisario
        {
            Nombre = vm.Nombre,
            Tipo = vm.Tipo,
            IdEvento = vm.IdEvento
        }, cancellationToken);
    }

    public async Task<ComisarioViewModel> GetById(int id)
    {
        var comisario = await comisarioRepository.GetByIdAsync(id);

        return new ComisarioViewModel
        {
            Id = comisario.Id,
            Nombre = comisario.Nombre,
            Tipo = comisario.Tipo,
            IdEvento = comisario.IdEvento
        };
    }

    public async Task Update(UpdateComisarioViewModel vm, CancellationToken cancellationToken)
    {
        await comisarioRepository.EditAsync(new Comisario
        {
            Id = vm.Id,
            Nombre = vm.Nombre,
            Tipo = vm.Tipo,
            IdEvento = vm.IdEvento
        }, cancellationToken);
    }

    public async Task Delete(int id, CancellationToken cancellationToken)
    {
        var deporte = await comisarioRepository.GetByIdAsync(id);
        await comisarioRepository.DeleteAsync(deporte, cancellationToken);
    }
}