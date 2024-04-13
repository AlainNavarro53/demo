using Demo.Business.Interfaces.Repositories;
using Demo.Business.Interfaces.Services;
using Demo.Business.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Demo.Business.Services;

public class EventoService(IEventoRepository eventoRepository) : IEventoService
{
    public async Task<List<EventoViewModel>> GetList(CancellationToken cancellationToken)
    {
        return await eventoRepository.AsQueryable().Select(p => new EventoViewModel
        {
            Id = p.Id,
            Nombre = p.Nombre
        }).ToListAsync(cancellationToken);
    }
}