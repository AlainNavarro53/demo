using System.ComponentModel.DataAnnotations;

namespace Demo.Business.ViewModels.Comisario;

public class UpdateComisarioViewModel
{
    [Range(1, int.MaxValue, ErrorMessage = "Id comisario es requerido.")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Debe ingresar un nombre")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "Debe ingresar un tipo")]
    public string Tipo { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un evento")]
    public int IdEvento { get; set; }
}