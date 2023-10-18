using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using formulariomvc.Models;

namespace formulariomvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet] 
    [Route("/")] 
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpGet] 
    [Route("privacy")] 
    public IActionResult Privacy()
    {
        return View("Privacy");
    }




    [HttpGet] 
    [Route("datos")]
    public IActionResult Datos(Formulario formulario){
        return View("Datos",formulario);
    }

    [HttpPost("formulario")]
    public RedirectToActionResult formulario (Formulario formulario){

        return RedirectToAction("Datos",formulario);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
