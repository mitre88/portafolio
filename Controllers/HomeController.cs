using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portafolio.Models;

namespace portafolio.Controllers;

public class HomeController : Controller  // Controller es una clase que se encarga de manejar las peticiones
{                                                                // siempre se usa Controler despúes del nombre de la clase
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()  // un controlador contiene 1 o más acciones 
    {                                           // las acciones son los metodos que se van a ejecutar en respesta a las peticiones 
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
