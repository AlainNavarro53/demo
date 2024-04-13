using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BotCrypt;
using Demo.Business.Interfaces.Services;
using Demo.Business.ViewModels.Usuario;
using Demo.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Demo.MVC.Controllers;

public class UsuarioController(IUsuarioService usuarioService, IConfiguration configuration) : BaseController
{
    public IActionResult Index()
    {
        return View();
    }

    [AllowAnonymous]
    public async Task<IActionResult> Login()
    {
        LoginViewModel vm = new();
        return View("Login", vm);
    }

    [AllowAnonymous]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginViewModel vm, CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid) return View("Login", vm);

        var user = await usuarioService.Login(vm.Username, vm.Password, cancellationToken);

        if (user is null ||
            vm.Password != Crypter.DecryptString("_s1Gc0mTh4Sh", user.Password))
        {
            ModelState.AddModelError("", "Usuario o contraseña incorrecta.");
            return View("Login", vm);
        }

        var jwt = GenerateToken(user);
        SaveTokenSecurely(jwt);

        return RedirectToRoute(new { controller = "Home", action = "Index" });
    }

    public IActionResult Logout()
    {
        Response.Cookies.Append("AccessToken", string.Empty);
        return RedirectToRoute(new { controller = "Home", action = "Index" });
    }

    private string GenerateToken(Usuario user)
    {
        // Generamos un token según los claims
        var claims = new List<Claim>
        {
            new(ClaimTypes.Sid, user.Id.ToString()),
            new(ClaimTypes.Name, user.Username)
        };

        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
        var tokenDescriptor = new JwtSecurityToken(
            configuration["Jwt:Issuer"],
            configuration["Jwt:Audience"],
            claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: credentials);

        var jwt = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

        return jwt;
    }

    private void SaveTokenSecurely(string token)
    {
        // Puoi salvare il token in un cookie sicuro, ad esempio:
        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Secure = true,
            SameSite = SameSiteMode.Strict,
            Expires = DateTime.UtcNow.AddHours(1)
        };

        Response.Cookies.Append("AccessToken", token, cookieOptions);
    }
}