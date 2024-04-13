using Demo.Business.Interfaces.Services;
using Demo.Business.ViewModels.Comisario;
using Microsoft.AspNetCore.Mvc;

namespace Demo.MVC.Controllers;

public class ComisarioController(IComisarioService comisarioService, IEventoService eventoService) : BaseController
{
    public async Task<IActionResult> Index(FiltroComisarioViewModel vm, CancellationToken cancellationToken)
    {
        return View(await comisarioService.GetList(vm, cancellationToken));
    }

    public async Task<IActionResult> Create(CancellationToken cancellationToken)
    {
        CreateComisarioViewModel vm = new();
        vm.Eventos = await eventoService.GetList(cancellationToken);
        return View("Create", vm);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateComisarioViewModel vm, CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            vm.Eventos = await eventoService.GetList(cancellationToken);
            return View("Create", vm);
        }

        await comisarioService.Create(vm, cancellationToken);
        return RedirectToRoute(new { controller = "Comisario", action = "Index" });
    }

    public async Task<IActionResult> Edit(int id, CancellationToken cancellationToken)
    {
        var vm = await comisarioService.GetById(id);
        vm.Eventos = await eventoService.GetList(cancellationToken);
        return View("Edit", vm);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(UpdateComisarioViewModel vm, CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            var model = await comisarioService.GetById(vm.Id);
            model.Eventos = await eventoService.GetList(cancellationToken);
            return View("Edit", model);
        }

        await comisarioService.Update(vm, cancellationToken);
        return RedirectToRoute(new { controller = "Comisario", action = "Index" });
    }

    public async Task<IActionResult> Delete(int id)
    {
        return View("Delete", await comisarioService.GetById(id));
    }

    [HttpPost]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        await comisarioService.Delete(id, cancellationToken);
        return RedirectToRoute(new { controller = "Comisario", action = "Index" });
    }
}