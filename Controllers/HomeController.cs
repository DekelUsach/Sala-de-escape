using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Downloads.Models;

namespace Downloads.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

public IActionResult Tutorial()
{
    return View();
}
public IActionResult Comenzar()
{
   return View();
}
public IActionResult Creditos()
{
   return View();
}
public IActionResult Habitacion(int sala, string clave)
{
    sala = 1;
    string habitacion="Habitacion" + sala;   
        
    return View(habitacion);
}


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
