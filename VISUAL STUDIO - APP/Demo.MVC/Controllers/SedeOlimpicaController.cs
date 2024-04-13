using Demo.Business.Interfaces.Services;
using Demo.Business.ViewModels.SedeOlimpica;
using Microsoft.AspNetCore.Mvc;

namespace Demo.MVC.Controllers;

public class SedeOlimpicaController(ISedeOlimpicaService deporteService) : BaseController
{
    public async Task<IActionResult> Index(FiltroSedeOlimpicaViewModel vm, CancellationToken cancellationToken)
    {
        return View(await deporteService.GetList(vm, cancellationToken));
    }

    public async Task<IActionResult> Create()
    {
        return View("Create", new CreateSedeOlimpicaViewModel());
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateSedeOlimpicaViewModel vm, CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
            return View("Create", new CreateSedeOlimpicaViewModel());

        await deporteService.Create(vm, cancellationToken);
        return RedirectToRoute(new { controller = "SedeOlimpica", action = "Index" });
    }

    public async Task<IActionResult> Edit(int id)
    {
        var vm = await deporteService.GetById(id);
        return View("Edit", vm);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(UpdateSedeOlimpicaViewModel vm, CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid) return View("Edit", vm);

        await deporteService.Update(vm, cancellationToken);
        return RedirectToRoute(new { controller = "SedeOlimpica", action = "Index" });
    }

    public async Task<IActionResult> Delete(int id)
    {
        return View("Delete", await deporteService.GetById(id));
    }

    [HttpPost]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        await deporteService.Delete(id, cancellationToken);
        return RedirectToRoute(new { controller = "SedeOlimpica", action = "Index" });
    }
}