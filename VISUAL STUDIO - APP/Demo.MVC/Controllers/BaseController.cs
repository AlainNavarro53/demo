using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.MVC.Controllers;

[Authorize]
public class BaseController : Controller
{
}