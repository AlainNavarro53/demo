using System.ComponentModel.DataAnnotations;

namespace Demo.Business.ViewModels.SedeOlimpica;

public class CreateSedeOlimpicaViewModel
{
    [Required(ErrorMessage = "Debe ingresar un nombre")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "Debe ingresar una ubicación.")]
    public string Ubicacion { get; set; }
    [Range(0, 999999.99, ErrorMessage = "Debe ingresar un presupuesto")]
    public decimal Presupuesto { get; set; }
}