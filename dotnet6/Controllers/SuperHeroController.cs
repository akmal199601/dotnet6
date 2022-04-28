using Microsoft.AspNetCore.Mvc;

namespace dotnet6.Controllers;

public class SuperHeroController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}