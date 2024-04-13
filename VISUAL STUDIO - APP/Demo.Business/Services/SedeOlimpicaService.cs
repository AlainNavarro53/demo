using Demo.Business.Interfaces.Repositories;
using Demo.Business.Interfaces.Services;
using Demo.Business.ViewModels.SedeOlimpica;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Business.Services;

public class SedeOlimpicaService(ISedeOlimpicaRepository deporteRepository) : ISedeOlimpicaService
{
    public async Task<List<SedeOlimpicaViewModel>> GetList(FiltroSedeOlimpicaViewModel filtroDeporteViewModel,
        CancellationToken cancellationToken)
    {
        var deporteQueryLis = deporteRepository.AsQueryable();

        if (!string.IsNullOrWhiteSpace(filtroDeporteViewModel.Name))
            deporteQueryLis = deporteQueryLis.Where(p => p.Nombre.ToLower().Contains(filtroDeporteViewModel.Name));

        return await deporteQueryLis.Select(p => new SedeOlimpicaViewModel
        {
            Id = p.Id,
            Nombre = p.Nombre,
            Ubicacion = p.Ubicacion,
            Presupuesto = p.Presupuesto
        }).ToListAsync(cancellationToken);
    }

    public async Task Create(CreateSedeOlimpicaViewModel vm, CancellationToken cancellationToken)
    {
        await deporteRepository.AddAsync(new SedeOlimpica
        {
            Nombre = vm.Nombre,
            Ubicacion = vm.Ubicacion,
            Presupuesto = vm.Presupuesto
        }, cancellationToken);
    }

    public async Task<SedeOlimpicaViewModel> GetById(int id)
    {
        var entity = await deporteRepository.GetByIdAsync(id);

        return new SedeOlimpicaViewModel
        {
            Id = entity.Id,
            Nombre = entity.Nombre,
            Ubicacion = entity.Ubicacion,
            Presupuesto = entity.Presupuesto
        };
    }

    public async Task Update(UpdateSedeOlimpicaViewModel vm, CancellationToken cancellationToken)
    {
        await deporteRepository.EditAsync(new SedeOlimpica
        {
            Id = vm.Id,
            Nombre = vm.Nombre,
            Ubicacion = vm.Ubicacion,
            Presupuesto = vm.Presupuesto
        }, cancellationToken);
    }

    public async Task Delete(int id, CancellationToken cancellationToken)
    {
        var deporte = await deporteRepository.GetByIdAsync(id);
        await deporteRepository.DeleteAsync(deporte, cancellationToken);
    }
}