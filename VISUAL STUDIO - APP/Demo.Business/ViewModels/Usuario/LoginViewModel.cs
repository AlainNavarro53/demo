using System.ComponentModel.DataAnnotations;

namespace Demo.Business.ViewModels.Usuario;

public class LoginViewModel
{
    [Required(ErrorMessage = "Debe ingresar un usuario")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Debe ingresar una contraseña")]
    public string Password { get; set; }
}